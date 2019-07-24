using System;
using System.Collections.Generic;
using System.Text;

namespace DataMallLibrary.Model.ActiveMobility
{
    public class Bicycle
    {
        public string odatametadata { get; set; }
        public BicycleDetails[] BicycleDetails { get; set; }
    }

    public class BicycleDetails
    {
        public string Description { get; set; }
        public float Latitude { get; set; }
        public float Longitude { get; set; }
        public string RackType { get; set; }
        public int RackCount { get; set; }
        public string ShelterIndicator { get; set; }
    }
}