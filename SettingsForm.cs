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
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            //Save all settings
            Properties.Settings.Default.InternalMqtt = mqttInternalBox.Checked;
            Properties.Settings.Default.AutostartMqtt = mqttAutoBox.Checked;
            Properties.Settings.Default.MqttIp = mqttServerIpBox.Text;
            Properties.Settings.Default.MqttUser = mqttUserBox.Text;
            Properties.Settings.Default.MqttPass = mqttPassBox.Text;
            Properties.Settings.Default.AutoConnectMqtt = autoConnectMqttBox.Checked;

            Properties.Settings.Default.AutostartWeb = webAutostartBox.Checked;

            Properties.Settings.Default.MysqlUser = mysqlUserBox.Text;
            Properties.Settings.Default.MysqlPass = mysqlPassBox.Text;

            //Write settings
            Properties.Settings.Default.Save();

            //Ask user to restart
            MessageBox.Show("Settings saved, please restart software for them to take full effect!");

            //Close form
            this.Close();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            //Load settings
            mqttInternalBox.Checked = Properties.Settings.Default.InternalMqtt;
            mqttAutoBox.Checked = Properties.Settings.Default.AutostartMqtt;
            mqttServerIpBox.Text = Properties.Settings.Default.MqttIp;
            mqttUserBox.Text = Properties.Settings.Default.MqttUser;
            mqttPassBox.Text = Properties.Settings.Default.MqttPass;
            autoConnectMqttBox.Checked = Properties.Settings.Default.AutoConnectMqtt;

            webAutostartBox.Checked = Properties.Settings.Default.AutostartWeb;

            mysqlUserBox.Text = Properties.Settings.Default.MysqlUser;
            mysqlPassBox.Text = Properties.Settings.Default.MysqlPass;
        }

    }
}
