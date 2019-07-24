using System;
using System.Collections.Generic;
using System.Text;

namespace DataMallLibrary.Model.PublicTransport
{

    public class BusStops
    {
        public string Odatametadata { get; set; }
        public BusStopsDetails[] BusStopsDetails { get; set; }
    }

    public class BusStopsDetails
    {
        public string BusStopCode { get; set; }
        public string RoadName { get; set; }
        public string Description { get; set; }
        public float Latitude { get; set; }
        public float Longitude { get; set; }
    }
}
