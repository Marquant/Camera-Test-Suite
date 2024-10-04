using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Camera_Test_Suite
{
    public partial class MqttLog : Form
    {
        public MqttLog()
        {
            InitializeComponent();
        }


        //Display connection msg in log
        public void MqttConnected()
        {
            MqttLogText.Text = "[" + DateTime.Now + "] MQTT Connection successful" + "\r\n";
        }

        //Sets last MQTT msg to label
        public void MqttLogMsg(string msg)
        {
            MqttLogText.Text = "[" + DateTime.Now + "] " + msg + "\r\n" + MqttLogText.Text;
        }
    }
}
