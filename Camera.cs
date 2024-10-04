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

        public List<string> MqttTopics
        { get; set; }

        public OccupancyDataClass OccupancyData
        { get; set; }

        public string LastMqtt
        { get; set; }

        public Camera (string cameraName, string cameraVendor, List<string> topicList, OccupancyDataClass occupancyData, string lastMqtt)
        {
            Name = cameraName;
            Vendor = cameraVendor;
            MqttTopics = topicList;
            OccupancyData = occupancyData;
            LastMqtt = lastMqtt;
        }

    }
}
