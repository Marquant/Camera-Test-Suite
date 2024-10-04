using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camera_Test_Suite
{
    public class OccupancyDataClass
    {
        public int Total
        { get; set; }

        public string Scenario
        { get; set; }

        public int Deviations
        { get; set; }

        public OccupancyDataClass (string scenario, int total, int deviations)
        {
            Scenario = scenario;
            Total = total;
            Deviations = deviations;
        }

        public OccupancyDataClass(string scenario, int total)
        {
            Scenario = scenario;
            Total = total;
        }
    }
}
