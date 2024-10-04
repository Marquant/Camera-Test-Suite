using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camera_Test_Suite
{
    class VendorParsing
    {

        //Parses Axis MQTT data
        public OccupancyDataClass ParseAxisOccupancy(string json)
        {
            //Create temp object
            OccupancyDataClass occupancyData = new OccupancyDataClass("Dummy", 0);

            dynamic results = JsonConvert.DeserializeObject<dynamic>(json);
            var total = results.message.data.total;
            var scenario = results.message.data.scenario;
            occupancyData.Total = Convert.ToInt16(total);
            occupancyData.Scenario = Convert.ToString(scenario);

            return occupancyData;
        }

        //Parses Bosch MQTT data
        public OccupancyDataClass ParseBoschOccupancy(string json)
        {
            //Create temp object
            OccupancyDataClass occupancyData = new OccupancyDataClass("Dummy", 0);

            dynamic results = JsonConvert.DeserializeObject<dynamic>(json);
            var total = results.Data.Count;
            var scenario = results.Source.Rule;
            occupancyData.Total = Convert.ToInt16(total);
            occupancyData.Scenario = Convert.ToString(scenario);

            return occupancyData;
        }
    }
}
