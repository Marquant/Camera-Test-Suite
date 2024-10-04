
namespace Camera_Test_Suite
{
    partial class SettingsForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.mqttStopBtn = new System.Windows.Forms.Button();
            this.mqttStartBtn = new System.Windows.Forms.Button();
            this.mqttAutoBox = new System.Windows.Forms.CheckBox();
            this.externalPanel = new System.Windows.Forms.Panel();
            this.autoConnectMqttBox = new System.Windows.Forms.CheckBox();
            this.mqttConnectBtn = new System.Windows.Forms.Button();
            this.mqttPassBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.mqttUserBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mqttServerIpBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mqttInternalBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.webAutostartBox = new System.Windows.Forms.CheckBox();
            this.webStopBtn = new System.Windows.Forms.Button();
            this.webStartBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.mysqlPassBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.mysqlUserBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.externalPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.mqttStopBtn);
            this.panel1.Controls.Add(this.mqttStartBtn);
            this.panel1.Controls.Add(this.mqttAutoBox);
            this.panel1.Controls.Add(this.externalPanel);
            this.panel1.Controls.Add(this.mqttInternalBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(376, 353);
            this.panel1.TabIndex = 0;
            // 
            // mqttStopBtn
            // 
            this.mqttStopBtn.Enabled = false;
            this.mqttStopBtn.Location = new System.Drawing.Point(241, 4);
            this.mqttStopBtn.Name = "mqttStopBtn";
            this.mqttStopBtn.Size = new System.Drawing.Size(75, 23);
            this.mqttStopBtn.TabIndex = 6;
            this.mqttStopBtn.Text = "Stop";
            this.mqttStopBtn.UseVisualStyleBackColor = true;
            // 
            // mqttStartBtn
            // 
            this.mqttStartBtn.Enabled = false;
            this.mqttStartBtn.Location = new System.Drawing.Point(160, 4);
            this.mqttStartBtn.Name = "mqttStartBtn";
            this.mqttStartBtn.Size = new System.Drawing.Size(75, 23);
            this.mqttStartBtn.TabIndex = 5;
            this.mqttStartBtn.Text = "Start";
            this.mqttStartBtn.UseVisualStyleBackColor = true;
            // 
            // mqttAutoBox
            // 
            this.mqttAutoBox.AutoSize = true;
            this.mqttAutoBox.Enabled = false;
            this.mqttAutoBox.Location = new System.Drawing.Point(160, 39);
            this.mqttAutoBox.Name = "mqttAutoBox";
            this.mqttAutoBox.Size = new System.Drawing.Size(142, 17);
            this.mqttAutoBox.TabIndex = 4;
            this.mqttAutoBox.Text = "Autostart MQTT Server?";
            this.mqttAutoBox.UseVisualStyleBackColor = true;
            // 
            // externalPanel
            // 
            this.externalPanel.Controls.Add(this.autoConnectMqttBox);
            this.externalPanel.Controls.Add(this.mqttConnectBtn);
            this.externalPanel.Controls.Add(this.mqttPassBox);
            this.externalPanel.Controls.Add(this.label5);
            this.externalPanel.Controls.Add(this.mqttUserBox);
            this.externalPanel.Controls.Add(this.label4);
            this.externalPanel.Controls.Add(this.mqttServerIpBox);
            this.externalPanel.Controls.Add(this.label2);
            this.externalPanel.Location = new System.Drawing.Point(6, 62);
            this.externalPanel.Name = "externalPanel";
            this.externalPanel.Size = new System.Drawing.Size(360, 286);
            this.externalPanel.TabIndex = 3;
            // 
            // autoConnectMqttBox
            // 
            this.autoConnectMqttBox.AutoSize = true;
            this.autoConnectMqttBox.Checked = true;
            this.autoConnectMqttBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.autoConnectMqttBox.Location = new System.Drawing.Point(7, 167);
            this.autoConnectMqttBox.Name = "autoConnectMqttBox";
            this.autoConnectMqttBox.Size = new System.Drawing.Size(139, 17);
            this.autoConnectMqttBox.TabIndex = 9;
            this.autoConnectMqttBox.Text = "Autoconnect to MQTT?";
            this.autoConnectMqttBox.UseVisualStyleBackColor = true;
            // 
            // mqttConnectBtn
            // 
            this.mqttConnectBtn.Location = new System.Drawing.Point(7, 190);
            this.mqttConnectBtn.Name = "mqttConnectBtn";
            this.mqttConnectBtn.Size = new System.Drawing.Size(75, 23);
            this.mqttConnectBtn.TabIndex = 8;
            this.mqttConnectBtn.Text = "Connect";
            this.mqttConnectBtn.UseVisualStyleBackColor = true;
            // 
            // mqttPassBox
            // 
            this.mqttPassBox.Location = new System.Drawing.Point(7, 141);
            this.mqttPassBox.Name = "mqttPassBox";
            this.mqttPassBox.PasswordChar = '*';
            this.mqttPassBox.Size = new System.Drawing.Size(260, 20);
            this.mqttPassBox.TabIndex = 7;
            this.mqttPassBox.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Password (Optional)";
            // 
            // mqttUserBox
            // 
            this.mqttUserBox.Location = new System.Drawing.Point(7, 101);
            this.mqttUserBox.Name = "mqttUserBox";
            this.mqttUserBox.Size = new System.Drawing.Size(260, 20);
            this.mqttUserBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Username (Optional)";
            // 
            // mqttServerIpBox
            // 
            this.mqttServerIpBox.Location = new System.Drawing.Point(7, 21);
            this.mqttServerIpBox.Name = "mqttServerIpBox";
            this.mqttServerIpBox.Size = new System.Drawing.Size(260, 20);
            this.mqttServerIpBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Server IP";
            // 
            // mqttInternalBox
            // 
            this.mqttInternalBox.AutoSize = true;
            this.mqttInternalBox.Enabled = false;
            this.mqttInternalBox.Location = new System.Drawing.Point(6, 38);
            this.mqttInternalBox.Name = "mqttInternalBox";
            this.mqttInternalBox.Size = new System.Drawing.Size(148, 17);
            this.mqttInternalBox.TabIndex = 2;
            this.mqttInternalBox.Text = "Use internal MQTT server";
            this.mqttInternalBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "MQTT Settings";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.webAutostartBox);
            this.panel2.Controls.Add(this.webStopBtn);
            this.panel2.Controls.Add(this.webStartBtn);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(396, 14);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(607, 45);
            this.panel2.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(3, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Not installed";
            // 
            // webAutostartBox
            // 
            this.webAutostartBox.AutoSize = true;
            this.webAutostartBox.Location = new System.Drawing.Point(310, 8);
            this.webAutostartBox.Name = "webAutostartBox";
            this.webAutostartBox.Size = new System.Drawing.Size(129, 17);
            this.webAutostartBox.TabIndex = 7;
            this.webAutostartBox.Text = "Autostart Webserver?";
            this.webAutostartBox.UseVisualStyleBackColor = true;
            // 
            // webStopBtn
            // 
            this.webStopBtn.Location = new System.Drawing.Point(526, 4);
            this.webStopBtn.Name = "webStopBtn";
            this.webStopBtn.Size = new System.Drawing.Size(75, 23);
            this.webStopBtn.TabIndex = 9;
            this.webStopBtn.Text = "Stop";
            this.webStopBtn.UseVisualStyleBackColor = true;
            // 
            // webStartBtn
            // 
            this.webStartBtn.Location = new System.Drawing.Point(445, 4);
            this.webStartBtn.Name = "webStartBtn";
            this.webStartBtn.Size = new System.Drawing.Size(75, 23);
            this.webStartBtn.TabIndex = 8;
            this.webStartBtn.Text = "Start";
            this.webStartBtn.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Webserver";
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(928, 372);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 2;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.mysqlPassBox);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.mysqlUserBox);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Location = new System.Drawing.Point(396, 65);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(607, 301);
            this.panel3.TabIndex = 3;
            // 
            // mysqlPassBox
            // 
            this.mysqlPassBox.Location = new System.Drawing.Point(6, 74);
            this.mysqlPassBox.Name = "mysqlPassBox";
            this.mysqlPassBox.PasswordChar = '*';
            this.mysqlPassBox.Size = new System.Drawing.Size(260, 20);
            this.mysqlPassBox.TabIndex = 11;
            this.mysqlPassBox.UseSystemPasswordChar = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Password";
            // 
            // mysqlUserBox
            // 
            this.mysqlUserBox.Location = new System.Drawing.Point(6, 34);
            this.mysqlUserBox.Name = "mysqlUserBox";
            this.mysqlUserBox.Size = new System.Drawing.Size(260, 20);
            this.mysqlUserBox.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Username";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 17);
            this.label9.TabIndex = 7;
            this.label9.Text = "MySQL";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 410);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Settings";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.externalPanel.ResumeLayout(false);
            this.externalPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button mqttStopBtn;
        private System.Windows.Forms.Button mqttStartBtn;
        private System.Windows.Forms.CheckBox mqttAutoBox;
        private System.Windows.Forms.Panel externalPanel;
        private System.Windows.Forms.TextBox mqttPassBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox mqttUserBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox mqttServerIpBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox mqttInternalBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox webAutostartBox;
        private System.Windows.Forms.Button webStopBtn;
        private System.Windows.Forms.Button webStartBtn;
        private System.Windows.Forms.Button mqttConnectBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox mysqlPassBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox mysqlUserBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox autoConnectMqttBox;
    }
}