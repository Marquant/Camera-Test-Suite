
namespace Camera_Test_Suite
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.startTab = new System.Windows.Forms.TabPage();
            this.howToBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.radioCounting = new System.Windows.Forms.RadioButton();
            this.radioCrossing = new System.Windows.Forms.RadioButton();
            this.radioOccupancy = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.settingsBtn = new System.Windows.Forms.Button();
            this.projectNameBox = new System.Windows.Forms.TextBox();
            this.createBtn = new System.Windows.Forms.Button();
            this.occupancyTab = new System.Windows.Forms.TabPage();
            this.occupancyCameraPanel = new System.Windows.Forms.Panel();
            this.occupancyDataPanel = new System.Windows.Forms.Panel();
            this.inconclusiveLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pullTimeBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.configCamerasBtn = new System.Windows.Forms.Button();
            this.eventsVoteLabel = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.testControlBtn = new System.Windows.Forms.Button();
            this.eventsCollectedLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.occupancyRunningTimeLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.occupancyTestName = new System.Windows.Forms.Label();
            this.lineCrossTab = new System.Windows.Forms.TabPage();
            this.resultsPage = new System.Windows.Forms.TabPage();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.resultsGridView = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.mqttStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel6 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel7 = new System.Windows.Forms.ToolStripStatusLabel();
            this.mysqlStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.hiddenLabel = new System.Windows.Forms.Label();
            this.testTimer = new System.Windows.Forms.Timer(this.components);
            this.tabControl.SuspendLayout();
            this.startTab.SuspendLayout();
            this.occupancyTab.SuspendLayout();
            this.occupancyDataPanel.SuspendLayout();
            this.resultsPage.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultsGridView)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.startTab);
            this.tabControl.Controls.Add(this.occupancyTab);
            this.tabControl.Controls.Add(this.lineCrossTab);
            this.tabControl.Controls.Add(this.resultsPage);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1470, 888);
            this.tabControl.TabIndex = 0;
            // 
            // startTab
            // 
            this.startTab.Controls.Add(this.howToBtn);
            this.startTab.Controls.Add(this.label2);
            this.startTab.Controls.Add(this.radioCounting);
            this.startTab.Controls.Add(this.radioCrossing);
            this.startTab.Controls.Add(this.radioOccupancy);
            this.startTab.Controls.Add(this.label1);
            this.startTab.Controls.Add(this.settingsBtn);
            this.startTab.Controls.Add(this.projectNameBox);
            this.startTab.Controls.Add(this.createBtn);
            this.startTab.Location = new System.Drawing.Point(4, 22);
            this.startTab.Name = "startTab";
            this.startTab.Padding = new System.Windows.Forms.Padding(3);
            this.startTab.Size = new System.Drawing.Size(1462, 862);
            this.startTab.TabIndex = 0;
            this.startTab.Text = "Start";
            this.startTab.UseVisualStyleBackColor = true;
            this.startTab.Click += new System.EventHandler(this.startTab_Click);
            // 
            // howToBtn
            // 
            this.howToBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.howToBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.howToBtn.Location = new System.Drawing.Point(628, 424);
            this.howToBtn.MaximumSize = new System.Drawing.Size(189, 35);
            this.howToBtn.MinimumSize = new System.Drawing.Size(189, 35);
            this.howToBtn.Name = "howToBtn";
            this.howToBtn.Size = new System.Drawing.Size(189, 35);
            this.howToBtn.TabIndex = 8;
            this.howToBtn.Text = "How to setup";
            this.howToBtn.UseVisualStyleBackColor = true;
            this.howToBtn.Click += new System.EventHandler(this.howToBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(646, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 26);
            this.label2.TabIndex = 7;
            this.label2.Text = "Start new test";
            // 
            // radioCounting
            // 
            this.radioCounting.AutoSize = true;
            this.radioCounting.Enabled = false;
            this.radioCounting.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioCounting.Location = new System.Drawing.Point(824, 297);
            this.radioCounting.Name = "radioCounting";
            this.radioCounting.Size = new System.Drawing.Size(144, 21);
            this.radioCounting.TabIndex = 6;
            this.radioCounting.Text = "Crossline Counting";
            this.radioCounting.UseVisualStyleBackColor = true;
            // 
            // radioCrossing
            // 
            this.radioCrossing.AutoSize = true;
            this.radioCrossing.Enabled = false;
            this.radioCrossing.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioCrossing.Location = new System.Drawing.Point(638, 297);
            this.radioCrossing.Name = "radioCrossing";
            this.radioCrossing.Size = new System.Drawing.Size(179, 21);
            this.radioCrossing.TabIndex = 5;
            this.radioCrossing.Text = "Line Crossing (distance)";
            this.radioCrossing.UseVisualStyleBackColor = true;
            // 
            // radioOccupancy
            // 
            this.radioOccupancy.AutoSize = true;
            this.radioOccupancy.Checked = true;
            this.radioOccupancy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioOccupancy.Location = new System.Drawing.Point(486, 297);
            this.radioOccupancy.Name = "radioOccupancy";
            this.radioOccupancy.Size = new System.Drawing.Size(146, 21);
            this.radioOccupancy.TabIndex = 4;
            this.radioOccupancy.TabStop = true;
            this.radioOccupancy.Text = "Occupancy in Area";
            this.radioOccupancy.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(666, 277);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Type of test";
            // 
            // settingsBtn
            // 
            this.settingsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.settingsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsBtn.Location = new System.Drawing.Point(628, 383);
            this.settingsBtn.MaximumSize = new System.Drawing.Size(189, 35);
            this.settingsBtn.MinimumSize = new System.Drawing.Size(189, 35);
            this.settingsBtn.Name = "settingsBtn";
            this.settingsBtn.Size = new System.Drawing.Size(189, 35);
            this.settingsBtn.TabIndex = 2;
            this.settingsBtn.Text = "Settings";
            this.settingsBtn.UseVisualStyleBackColor = true;
            this.settingsBtn.Click += new System.EventHandler(this.settingsBtn_Click);
            // 
            // projectNameBox
            // 
            this.projectNameBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.projectNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectNameBox.Location = new System.Drawing.Point(576, 248);
            this.projectNameBox.MaximumSize = new System.Drawing.Size(289, 26);
            this.projectNameBox.MinimumSize = new System.Drawing.Size(289, 26);
            this.projectNameBox.Name = "projectNameBox";
            this.projectNameBox.Size = new System.Drawing.Size(289, 26);
            this.projectNameBox.TabIndex = 1;
            this.projectNameBox.Text = "Name of test..";
            this.projectNameBox.Click += new System.EventHandler(this.projectNameBox_Click);
            // 
            // createBtn
            // 
            this.createBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.createBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createBtn.Location = new System.Drawing.Point(628, 342);
            this.createBtn.MaximumSize = new System.Drawing.Size(189, 35);
            this.createBtn.MinimumSize = new System.Drawing.Size(189, 35);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(189, 35);
            this.createBtn.TabIndex = 0;
            this.createBtn.Text = "Continue";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // occupancyTab
            // 
            this.occupancyTab.Controls.Add(this.occupancyCameraPanel);
            this.occupancyTab.Controls.Add(this.occupancyDataPanel);
            this.occupancyTab.Location = new System.Drawing.Point(4, 22);
            this.occupancyTab.Name = "occupancyTab";
            this.occupancyTab.Padding = new System.Windows.Forms.Padding(3);
            this.occupancyTab.Size = new System.Drawing.Size(1462, 862);
            this.occupancyTab.TabIndex = 1;
            this.occupancyTab.Text = "Occupancy";
            this.occupancyTab.UseVisualStyleBackColor = true;
            // 
            // occupancyCameraPanel
            // 
            this.occupancyCameraPanel.AutoScroll = true;
            this.occupancyCameraPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.occupancyCameraPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.occupancyCameraPanel.Location = new System.Drawing.Point(3, 358);
            this.occupancyCameraPanel.Name = "occupancyCameraPanel";
            this.occupancyCameraPanel.Size = new System.Drawing.Size(1456, 501);
            this.occupancyCameraPanel.TabIndex = 1;
            // 
            // occupancyDataPanel
            // 
            this.occupancyDataPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.occupancyDataPanel.Controls.Add(this.inconclusiveLabel);
            this.occupancyDataPanel.Controls.Add(this.label10);
            this.occupancyDataPanel.Controls.Add(this.label5);
            this.occupancyDataPanel.Controls.Add(this.pullTimeBox);
            this.occupancyDataPanel.Controls.Add(this.label4);
            this.occupancyDataPanel.Controls.Add(this.configCamerasBtn);
            this.occupancyDataPanel.Controls.Add(this.eventsVoteLabel);
            this.occupancyDataPanel.Controls.Add(this.label15);
            this.occupancyDataPanel.Controls.Add(this.label8);
            this.occupancyDataPanel.Controls.Add(this.label9);
            this.occupancyDataPanel.Controls.Add(this.testControlBtn);
            this.occupancyDataPanel.Controls.Add(this.eventsCollectedLabel);
            this.occupancyDataPanel.Controls.Add(this.label6);
            this.occupancyDataPanel.Controls.Add(this.occupancyRunningTimeLabel);
            this.occupancyDataPanel.Controls.Add(this.label3);
            this.occupancyDataPanel.Controls.Add(this.occupancyTestName);
            this.occupancyDataPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.occupancyDataPanel.Location = new System.Drawing.Point(3, 3);
            this.occupancyDataPanel.Name = "occupancyDataPanel";
            this.occupancyDataPanel.Size = new System.Drawing.Size(1456, 349);
            this.occupancyDataPanel.TabIndex = 0;
            // 
            // inconclusiveLabel
            // 
            this.inconclusiveLabel.AutoSize = true;
            this.inconclusiveLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inconclusiveLabel.Location = new System.Drawing.Point(6, 187);
            this.inconclusiveLabel.Name = "inconclusiveLabel";
            this.inconclusiveLabel.Size = new System.Drawing.Size(16, 17);
            this.inconclusiveLabel.TabIndex = 18;
            this.inconclusiveLabel.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 170);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(155, 17);
            this.label10.TabIndex = 17;
            this.label10.Text = "Inconclusive events:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Event pull time";
            // 
            // pullTimeBox
            // 
            this.pullTimeBox.Location = new System.Drawing.Point(8, 294);
            this.pullTimeBox.Name = "pullTimeBox";
            this.pullTimeBox.Size = new System.Drawing.Size(20, 20);
            this.pullTimeBox.TabIndex = 14;
            this.pullTimeBox.Text = "5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 301);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "s";
            // 
            // configCamerasBtn
            // 
            this.configCamerasBtn.Location = new System.Drawing.Point(4, 320);
            this.configCamerasBtn.Name = "configCamerasBtn";
            this.configCamerasBtn.Size = new System.Drawing.Size(152, 23);
            this.configCamerasBtn.TabIndex = 13;
            this.configCamerasBtn.Text = "Add camera";
            this.configCamerasBtn.UseVisualStyleBackColor = true;
            this.configCamerasBtn.Click += new System.EventHandler(this.configCamerasBtn_Click);
            // 
            // eventsVoteLabel
            // 
            this.eventsVoteLabel.AutoSize = true;
            this.eventsVoteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventsVoteLabel.Location = new System.Drawing.Point(6, 153);
            this.eventsVoteLabel.Name = "eventsVoteLabel";
            this.eventsVoteLabel.Size = new System.Drawing.Size(16, 17);
            this.eventsVoteLabel.TabIndex = 12;
            this.eventsVoteLabel.Text = "0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(6, 136);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(182, 17);
            this.label15.TabIndex = 11;
            this.label15.Text = "Events decided by vote:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 17);
            this.label8.TabIndex = 10;
            this.label8.Text = "Occupancy in area";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 17);
            this.label9.TabIndex = 9;
            this.label9.Text = "Type of test:";
            // 
            // testControlBtn
            // 
            this.testControlBtn.Location = new System.Drawing.Point(162, 320);
            this.testControlBtn.Name = "testControlBtn";
            this.testControlBtn.Size = new System.Drawing.Size(75, 23);
            this.testControlBtn.TabIndex = 8;
            this.testControlBtn.Text = "Start test";
            this.testControlBtn.UseVisualStyleBackColor = true;
            this.testControlBtn.Click += new System.EventHandler(this.testControlBtn_Click);
            // 
            // eventsCollectedLabel
            // 
            this.eventsCollectedLabel.AutoSize = true;
            this.eventsCollectedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventsCollectedLabel.Location = new System.Drawing.Point(6, 119);
            this.eventsCollectedLabel.Name = "eventsCollectedLabel";
            this.eventsCollectedLabel.Size = new System.Drawing.Size(16, 17);
            this.eventsCollectedLabel.TabIndex = 4;
            this.eventsCollectedLabel.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Events collected:";
            // 
            // occupancyRunningTimeLabel
            // 
            this.occupancyRunningTimeLabel.AutoSize = true;
            this.occupancyRunningTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.occupancyRunningTimeLabel.Location = new System.Drawing.Point(6, 85);
            this.occupancyRunningTimeLabel.Name = "occupancyRunningTimeLabel";
            this.occupancyRunningTimeLabel.Size = new System.Drawing.Size(64, 17);
            this.occupancyRunningTimeLabel.TabIndex = 2;
            this.occupancyRunningTimeLabel.Text = "00:00:00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(233, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Running time (hrs:min:sec:ms):";
            // 
            // occupancyTestName
            // 
            this.occupancyTestName.AutoSize = true;
            this.occupancyTestName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.occupancyTestName.Location = new System.Drawing.Point(5, 4);
            this.occupancyTestName.Name = "occupancyTestName";
            this.occupancyTestName.Size = new System.Drawing.Size(100, 20);
            this.occupancyTestName.TabIndex = 0;
            this.occupancyTestName.Text = "Name of test";
            // 
            // lineCrossTab
            // 
            this.lineCrossTab.Location = new System.Drawing.Point(4, 22);
            this.lineCrossTab.Name = "lineCrossTab";
            this.lineCrossTab.Size = new System.Drawing.Size(1462, 862);
            this.lineCrossTab.TabIndex = 2;
            this.lineCrossTab.Text = "Line Crossing";
            this.lineCrossTab.UseVisualStyleBackColor = true;
            // 
            // resultsPage
            // 
            this.resultsPage.Controls.Add(this.toolStrip1);
            this.resultsPage.Controls.Add(this.resultsGridView);
            this.resultsPage.Location = new System.Drawing.Point(4, 22);
            this.resultsPage.Name = "resultsPage";
            this.resultsPage.Size = new System.Drawing.Size(1462, 862);
            this.resultsPage.TabIndex = 3;
            this.resultsPage.Text = "Results";
            this.resultsPage.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripComboBox1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1462, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(68, 22);
            this.toolStripLabel1.Text = "Filter event:";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Items.AddRange(new object[] {
            "Car"});
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 25);
            // 
            // resultsGridView
            // 
            this.resultsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultsGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.resultsGridView.Location = new System.Drawing.Point(0, 28);
            this.resultsGridView.Name = "resultsGridView";
            this.resultsGridView.Size = new System.Drawing.Size(1462, 834);
            this.resultsGridView.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.mqttStatusLabel,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4,
            this.toolStripStatusLabel5,
            this.toolStripStatusLabel6,
            this.toolStripStatusLabel7,
            this.mysqlStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 866);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1470, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(76, 17);
            this.toolStripStatusLabel1.Text = "MQTT Server:";
            // 
            // mqttStatusLabel
            // 
            this.mqttStatusLabel.ForeColor = System.Drawing.Color.Red;
            this.mqttStatusLabel.Name = "mqttStatusLabel";
            this.mqttStatusLabel.Size = new System.Drawing.Size(38, 17);
            this.mqttStatusLabel.Text = "Down";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(16, 17);
            this.toolStripStatusLabel3.Text = " | ";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(65, 17);
            this.toolStripStatusLabel4.Text = "Webserver:";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.ForeColor = System.Drawing.Color.Red;
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(38, 17);
            this.toolStripStatusLabel5.Text = "Down";
            // 
            // toolStripStatusLabel6
            // 
            this.toolStripStatusLabel6.Name = "toolStripStatusLabel6";
            this.toolStripStatusLabel6.Size = new System.Drawing.Size(16, 17);
            this.toolStripStatusLabel6.Text = " | ";
            // 
            // toolStripStatusLabel7
            // 
            this.toolStripStatusLabel7.Name = "toolStripStatusLabel7";
            this.toolStripStatusLabel7.Size = new System.Drawing.Size(108, 17);
            this.toolStripStatusLabel7.Text = "MySql Connection:";
            // 
            // mysqlStatusLabel
            // 
            this.mysqlStatusLabel.ForeColor = System.Drawing.Color.Red;
            this.mysqlStatusLabel.Name = "mysqlStatusLabel";
            this.mysqlStatusLabel.Size = new System.Drawing.Size(38, 17);
            this.mysqlStatusLabel.Text = "Down";
            // 
            // hiddenLabel
            // 
            this.hiddenLabel.AutoSize = true;
            this.hiddenLabel.Location = new System.Drawing.Point(13, 837);
            this.hiddenLabel.Name = "hiddenLabel";
            this.hiddenLabel.Size = new System.Drawing.Size(35, 13);
            this.hiddenLabel.TabIndex = 4;
            this.hiddenLabel.Text = "label7";
            this.hiddenLabel.Visible = false;
            this.hiddenLabel.TextChanged += new System.EventHandler(this.hiddenLabel_TextChanged);
            // 
            // testTimer
            // 
            this.testTimer.Interval = 5000;
            this.testTimer.Tick += new System.EventHandler(this.testTimer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1470, 888);
            this.Controls.Add(this.hiddenLabel);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1490, 931);
            this.MinimumSize = new System.Drawing.Size(1490, 931);
            this.Name = "MainForm";
            this.Text = "ATS - Camera Test";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl.ResumeLayout(false);
            this.startTab.ResumeLayout(false);
            this.startTab.PerformLayout();
            this.occupancyTab.ResumeLayout(false);
            this.occupancyDataPanel.ResumeLayout(false);
            this.occupancyDataPanel.PerformLayout();
            this.resultsPage.ResumeLayout(false);
            this.resultsPage.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultsGridView)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage startTab;
        private System.Windows.Forms.Button settingsBtn;
        private System.Windows.Forms.TextBox projectNameBox;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.TabPage occupancyTab;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel mqttStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.TabPage lineCrossTab;
        private System.Windows.Forms.RadioButton radioCounting;
        private System.Windows.Forms.RadioButton radioCrossing;
        private System.Windows.Forms.RadioButton radioOccupancy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel occupancyCameraPanel;
        private System.Windows.Forms.Panel occupancyDataPanel;
        private System.Windows.Forms.Label eventsVoteLabel;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button testControlBtn;
        private System.Windows.Forms.Label eventsCollectedLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label occupancyRunningTimeLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label occupancyTestName;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel6;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel7;
        private System.Windows.Forms.ToolStripStatusLabel mysqlStatusLabel;
        private System.Windows.Forms.Label hiddenLabel;
        private System.Windows.Forms.Button configCamerasBtn;
        private System.Windows.Forms.Timer testTimer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox pullTimeBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label inconclusiveLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TabPage resultsPage;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.DataGridView resultsGridView;
        private System.Windows.Forms.Button howToBtn;
    }
}

