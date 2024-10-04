using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camera_Test_Suite
{
    public class Camera
    {
        public int CameraId
        { get; set; }

        public string Name
        { get; set; }

        public string Vendor
        { get; set; }

        public string MqttTopic
        { get; set; }

        public Camera (string cameraName, string cameraVendor, string mqttTopic)
        {
            Name = cameraName;
            Vendor = cameraVendor;
            MqttTopic = mqttTopic;
        }

    }
}
