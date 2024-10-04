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

namespace Camera_Test_Suite
{
    public partial class MqttTopic : Form
    {

        Camera currentCamera;
        MqttClient currentClient;
        MqttLog currentLog;

        public MqttTopic(Camera camera, MqttClient mqttClient, MqttLog mqttLogWindow)
        {
            InitializeComponent();

            //Fill list with subscrbied topics
            currentCamera = camera;
            currentClient = mqttClient;
            currentLog = mqttLogWindow;
        }


        //Function for removing item in list of subscribed topics
        private void removeBtn_Click(object sender, EventArgs e)
        {
            selectedMqttList.Items.Remove(selectedMqttList.SelectedItem);
        }

        //Add topic to list
        private void addBtn_Click(object sender, EventArgs e)
        {
            selectedMqttList.Items.Add(addTopicBox.Text);
            addTopicBox.Text = "";
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            //Iterate and subscribe to topics

            //Clear old topics and unsubscribe
            //Check if not empty

            foreach (string topic in currentCamera.MqttTopics)
            {
                if (topic != null)
                {
                    currentClient.Unsubscribe(new string[] { topic });
                    currentLog.MqttLogMsg("Unsubscribed from: " + topic);
                }              
            }


            //Clear list
            currentCamera.MqttTopics.Clear();

            //Subscribe to each topic and add elements in datalists
            foreach (string topic in selectedMqttList.Items)
            {
                if (topic != null)
                {
                    //Subscribe
                    currentClient.Subscribe(new string[] { topic }, new byte[] { MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE });
                    currentLog.MqttLogMsg("Subscribed to: " + topic);

                    //Add to camera subscription list
                    currentCamera.MqttTopics.Add(topic);
                }
            }

            //Close form
            this.Close();
        }

        private void MqttTopic_Load(object sender, EventArgs e)
        {
            try
            {
                //Check so not empty
                if (currentCamera.MqttTopics.Count > 0)
                {
                    foreach (string mqttTopic in currentCamera.MqttTopics)
                    {
                        selectedMqttList.Items.Add(mqttTopic);
                    }
                }
            }
            catch
            {
                //No cameras in list yet
            }
        }
    }
}
