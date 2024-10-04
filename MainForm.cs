using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;
using System.Diagnostics;
using System.Net.Http;
using System.Text.Json;
using System.Net.Http.Headers;


namespace Camera_Test_Suite
{
    public partial class MainForm : Form
    {

        // Create MQTT Client instance
        MqttClient mqttClient;

        //Create MQTT log dialog
        MqttLog mqttLogWindow = new MqttLog();

        //Public vars
        string projectName;
        private string[] vendorList = { "Axis", "Bosch" }; //, "Avigilon", "Hanwa", "Panasonic" 
        public int typeOfTest; //1 = Occupancy, 2 = Line crossing, 3 = Crossline counting
        List<Camera> cameraList = new List<Camera>();

        List<OccupancyDataClass> occupancyData = new List<OccupancyDataClass>();
        List<int> deviations = new List<int>();
        int voteDescisions = 0;
        int eventsCollected = 0;
        int inconclusivesCollected = 0;
        bool testRunning = false;
        List<string> lastMQTT = new List<string>();
        Stopwatch elapsedStopwatch = new Stopwatch();
        Timer elapsedTimer = new Timer();


        VendorParsing vendorParser = new VendorParsing();


        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //Disable tabs
            tabControl.TabPages.Remove(lineCrossTab);
            tabControl.TabPages.Remove(occupancyTab);
            tabControl.TabPages.Remove(resultsPage);

            //Display MQTT Logger
            mqttLogWindow.Show();

            //Check if internal or external MQTT client
            if (Properties.Settings.Default.InternalMqtt != true)
            {
                //Using external MQTT
                mqttClient = new MqttClient(Properties.Settings.Default.MqttIp);
            }
            else
            {
                //Using internal MQTT
                mqttClient = new MqttClient("localhost");
            }

            //Should we autoconnect to MQTT?
            if (Properties.Settings.Default.AutoConnectMqtt)
            {
                //Connect MQTT
                string clientId = Guid.NewGuid().ToString();

                try
                {
                    mqttClient.Connect(clientId);


                    if (mqttClient.IsConnected)
                    {
                        mqttLogWindow.MqttConnected();
                        mqttClient.MqttMsgPublishReceived += client_MqttMsgPublishReceived;
                        mqttStatusLabel.Text = "Connected";
                        mqttStatusLabel.ForeColor = Color.Green;
                    }
                }
                catch
                {
                    mqttStatusLabel.Text = "Error connecting!";
                    mqttStatusLabel.ForeColor = Color.Red;
                }

            }

        }

        //Handle incomming MQTT messages
        private void client_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
        {
            // handle message received 
            string topic = e.Topic;
            string value = Encoding.UTF8.GetString(e.Message);

            //Invoke MQTT msg function
            hiddenLabel.Invoke(new Action(() => hiddenLabel.Text = value));

            //Parse MQTT and save to correct camera as last MQTT msg
            foreach (Camera camera in cameraList)
            {
                //Check if topic matches camera topic
                if (camera.MqttTopic == e.Topic)
                {
                    //Save MQTT data to correct camera
                    lastMQTT[cameraList.IndexOf(camera)] = hiddenLabel.Text;

                }
            }

        }

        private void startTab_Click(object sender, EventArgs e)
        {

        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {
            //Create settings window
            SettingsForm settingsWindow = new SettingsForm();
            settingsWindow.ShowDialog();
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            //Create setup for project
            projectName = projectNameBox.Text;

            //Set type of project and Switch tab page
            if (radioOccupancy.Checked)
            {
                typeOfTest = 1;
                tabControl.TabPages.Add(occupancyTab);
                occupancyTestName.Text = projectNameBox.Text;
            }
            else if (radioCrossing.Checked)
            {
                typeOfTest = 2;
            }
            else if (radioCounting.Checked)
            {
                typeOfTest = 3;
            }



            //Remove startpage
            tabControl.TabPages.Remove(startTab);

        }


        //Handles incoming MQTT msgs
        private void hiddenLabel_TextChanged(object sender, EventArgs e)
        {
            //Add message to log
            mqttLogWindow.MqttLogMsg(hiddenLabel.Text);
        }

        //Opens new camera window
        private void configCamerasBtn_Click(object sender, EventArgs e)
        {

            CameraSetup setupCameras = new CameraSetup(vendorList);
            var result = setupCameras.ShowDialog();

            //Fetch config
            if (result == DialogResult.OK)
            {
                cameraList.Add(setupCameras.camera);

                //Set up cameras accordingly
                setupCameraLists();
            }
        }


        //Iterate cameras and setup lists accordingly
        private void setupCameraLists()
        {

            //Clear and reset deviations and mqtt list
            lastMQTT.Clear();
            deviations.Clear();
            occupancyData.Clear();
            occupancyCameraPanel.Controls.Clear();

            //Defint vars for spacing
            int left = 325;
            int horizontal = 0;
            int height = 400;
            int currentHeight = 15;

            //Subscribe to each topic and add elements in datalists
            foreach (Camera camera in cameraList)
            {
                if (camera.MqttTopic != null)
                {
                    //Subscribe
                    mqttClient.Subscribe(new string[] { camera.MqttTopic }, new byte[] { MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE });
                    mqttLogWindow.MqttLogMsg("Subscribed to: " + camera.MqttTopic);

                    //Add camera panel to correct test panel
                    if (typeOfTest == 1)
                    {
                        Panel tempPanel = addCameraElement(camera);
                        occupancyCameraPanel.Controls.Add(tempPanel);
                        tempPanel.BringToFront();
                        tempPanel.Location = new Point((left * horizontal) + 10, currentHeight);
                    }

                    //Add horizontal plane
                    horizontal++;

                    //Check if reached limit, then add new row
                    if (horizontal == 4)
                    {
                        currentHeight = currentHeight + height;
                        horizontal = 0;
                    }

                    //Setup lists
                    lastMQTT.Add("Dummy");
                    deviations.Add(0);

                    //Fill occupancylist with dummy data
                    OccupancyDataClass tempObject = new OccupancyDataClass("Dummy", 0);
                    occupancyData.Add(tempObject);

                }
            }

        }

        //Adds a camera to the camerapanel
        private Panel addCameraElement(Camera camera)
        {
            int cameraID = cameraList.IndexOf(camera); //Get id of camera
            Panel cameraPanel = new Panel(); //Create panel
            cameraPanel.Name = "Camera" + cameraID; //Set name

            cameraPanel.Size = new Size(319, 375); //Set size of panel
            cameraPanel.BorderStyle = BorderStyle.FixedSingle; //Set borderstyle
            cameraPanel.Location = new Point(14, 17);

            Label cameraNameLabel = new Label(); //Create name label
            cameraPanel.Controls.Add(cameraNameLabel); //Add name label to panel
            cameraNameLabel.Location = new Point(23, 0); //Set position
            cameraNameLabel.Text = camera.Name; //Set text of name label

            Label nameLabel = new Label(); //Add label for screenshot text
            cameraPanel.Controls.Add(nameLabel); //Add to panel
            nameLabel.Location = new Point(23, 40); //Set position
            nameLabel.Text = "Camera name: " + camera.Name; //Set text

            Label cameraStatusLabel = new Label(); //Add label for screenshot text
            cameraPanel.Controls.Add(cameraStatusLabel); //Add to panel
            cameraStatusLabel.Location = new Point(261, 0); //Set position
            cameraStatusLabel.Text = "O"; //Set text
            cameraStatusLabel.ForeColor = Color.Green;
            cameraStatusLabel.Font = new Font("Arial Black", 16, FontStyle.Bold);
            cameraStatusLabel.Name = "CameraStatusLabel" + cameraID;


            PictureBox snapshotBox = new PictureBox(); //Create picturebox for snapshot
            cameraPanel.Controls.Add(snapshotBox); //Add to panel
            snapshotBox.Name = "CameraPictureBox" + cameraID; //Set id of box
            snapshotBox.Size = new Size(267, 187); //Set size
            snapshotBox.Location = new Point(26, 50); //Set location
            snapshotBox.BackgroundImageLayout = ImageLayout.Zoom; //Set imagelayout



            //Specific labels for test
            if (typeOfTest == 1)
            {
                Label objectCountLabel = new Label(); //Add label for objectcount heading text
                cameraPanel.Controls.Add(objectCountLabel); //Add to panel
                objectCountLabel.Location = new Point(26, 260); //Set position
                objectCountLabel.Text = "Last object count:"; //Set text

                Label objectCountCameraLabel = new Label(); //Add label for object count 
                cameraPanel.Controls.Add(objectCountCameraLabel); //Add to panel
                objectCountCameraLabel.Location = new Point(29, 285); //Set position
                objectCountCameraLabel.Text = "0"; //Set text
                objectCountCameraLabel.Name = "cameraObjectCount" + cameraID;

                Label deviationLabel = new Label(); //Add label for deviation label text
                cameraPanel.Controls.Add(deviationLabel); //Add to panel
                deviationLabel.Location = new Point(26, 310); //Set position
                deviationLabel.Text = "Deviations:"; //Set text

                Label deviationCountCameraLabel = new Label(); //Add label for deviation count
                cameraPanel.Controls.Add(deviationCountCameraLabel); //Add to panel
                deviationCountCameraLabel.Location = new Point(29, 335); //Set position
                deviationCountCameraLabel.Text = "0"; //Set text
                deviationCountCameraLabel.Name = "cameraDeviationCount" + cameraID;

            }

            return cameraPanel;
        }


        //Function responsible for start/stopping test
        private void testControlBtn_Click(object sender, EventArgs e)
        {
            //Check if test is running otherwise start it
            if (!testRunning)
            {
                testTimer.Interval = Convert.ToInt16(pullTimeBox.Text) * 1000;
                testControlBtn.Text = "Stop test";
                testTimer.Enabled = true;
                testTimer.Start();

                //Mark test as started
                testRunning = true;

                //Set up elapsed stopwatch and timer
                elapsedTimer.Interval = 1;
                elapsedTimer.Tick += T1_Tick;
                elapsedTimer.Start();
                elapsedStopwatch.Start();
            }
            else
            {
                //Stop test
                testTimer.Stop();
                elapsedStopwatch.Stop();
                elapsedTimer.Stop();
                testRunning = false;

                testControlBtn.Text = "Start test";
            }

        }

        //Handles ticks for elapsed time
        private void T1_Tick(object sender, EventArgs e)
        {
            // Get the elapsed time as a TimeSpan value.
            var ts = elapsedStopwatch.Elapsed;

            // Format and display the TimeSpan value.
            occupancyRunningTimeLabel.Text = $"{ts.Hours}:{ts.Minutes}:{ts.Seconds}.{ts.Milliseconds / 10}";
        }

        private void testTimer_Tick(object sender, EventArgs e)
        {
            if (testRunning)
            {
                ///////////////// Test is occupancy /////////////////////
                if (typeOfTest == 1)
                {
                    occupancyTestTick();
                }
            }
        }

        //Function for showing the how to guides
        private void howToBtn_Click(object sender, EventArgs e)
        {
            GuideForm guide = new GuideForm();
            guide.Show();
        }

        //Clear text on first enter
        private void projectNameBox_Click(object sender, EventArgs e)
        {
            if (projectNameBox.Text == "Name of test..")
            {
                projectNameBox.Text = "";
            }
        }

        //Function handles assignments for every tick during an occupancy test
        private void occupancyTestTick()
        {
            //If empty data is provided, invalidate round
            bool testInvalidated = false;

            //Iterate each camera
            foreach (Camera camera in cameraList)
            {
                //Get ID of current camera
                int id = cameraList.IndexOf(camera);

                //Fetch latest MQTT message and parse
                if (lastMQTT[id] == "Dummy")
                {
                    testInvalidated = true;
                }

                //Occupancy test, choose vendor
                if (camera.Vendor == "Axis" && !testInvalidated)
                {
                    //Axis is vendor, use parsing class
                    occupancyData[id] = vendorParser.ParseAxisOccupancy(lastMQTT[id]);
                }
                else if (camera.Vendor == "Bosch" && !testInvalidated)
                {
                    //Vendor is Bosch, parse
                    occupancyData[id] = vendorParser.ParseBoschOccupancy(lastMQTT[id]);
                }

            }

            //Conclude data collected

            if (!testInvalidated)
            {
                //Total events
                eventsCollected++;
                eventsCollectedLabel.Text = eventsCollected.ToString();

                //Create temp array of occupancyData
                List<int> tempOccupancy = new List<int>();

                //Set object count for each camera
                foreach (Camera camera in cameraList)
                {
                    int id = cameraList.IndexOf(camera);
                    if (occupancyData[id].Scenario != "Dummy")
                    {
                        //Set count
                        string tempName = "cameraObjectCount" + id.ToString();
                        string tempPanel = "Camera" + id.ToString();
                        Panel panel = (Panel)occupancyCameraPanel.Controls[tempPanel];
                        panel.Controls[tempName].Text = occupancyData[id].Total.ToString();

                        tempOccupancy.Add(occupancyData[id].Total);

                    }
                }

                //Compare occupancy data and get most common value
                var cnt = new Dictionary<int, int>();

                foreach (int value in tempOccupancy)
                {
                    if (cnt.ContainsKey(value))
                    {
                        cnt[value]++;
                    }
                    else
                    {
                        cnt.Add(value, 1);
                    }
                }
                int mostCommonValue = 0;
                int highestCount = 0;
                foreach (KeyValuePair<int, int> pair in cnt)
                {
                    if (pair.Value > highestCount)
                    {
                        mostCommonValue = pair.Key;
                        highestCount = pair.Value;
                    }
                }

                bool deviated = false; //Reset deviation

                //Check if inconslusive result (Eg. higest occuring number is only present once)
                if (highestCount > 1)
                {
                    //Set deviation for any camera not containing most common value
                    foreach (Camera camera in cameraList)
                    {
                        int id = cameraList.IndexOf(camera);
                        if (occupancyData[id].Total != mostCommonValue)
                        {
                            deviations[id]++; //Add 1 to deviations

                            //Check if round has deviated and if so decided by vote
                            if (!deviated)
                            {
                                deviated = true;
                                voteDescisions++;
                                eventsVoteLabel.Text = voteDescisions.ToString();
                            }

                            //Set count
                            string tempName = "cameraDeviationCount" + id.ToString();
                            string tempStatus = "CameraStatusLabel" + id.ToString();
                            string tempPanel = "Camera" + id.ToString();
                            Panel panel = (Panel)occupancyCameraPanel.Controls[tempPanel];
                            panel.Controls[tempName].Text = deviations[id].ToString();

                            //Set status to red
                            panel.Controls[tempStatus].ForeColor = Color.Red;
                        }
                        else
                        {
                            //Set green status
                            string tempStatus = "CameraStatusLabel" + id.ToString();
                            string tempPanel = "Camera" + id.ToString();
                            Panel panel = (Panel)occupancyCameraPanel.Controls[tempPanel];
                            panel.Controls[tempStatus].ForeColor = Color.Green;
                        }
                    }
                }
                else
                {
                    //If not, add inconclusive
                    for (int i = 0; i < cameraList.Count; i++)
                    {
                        //Set orange status
                        string tempStatus = "CameraStatusLabel" + i.ToString();
                        string tempPanel = "Camera" + i.ToString();
                        Panel panel = (Panel)occupancyCameraPanel.Controls[tempPanel];
                        panel.Controls[tempStatus].ForeColor = Color.Orange;
                    }

                    inconclusivesCollected++;
                    inconclusiveLabel.Text = inconclusivesCollected.ToString();
                }
            }
        }
    }
}
