using System;
using System.Collections.Generic;
using System.Text;

namespace DataMallLibrary.Model.PublicTransport
{
    public class BusStopsODPV
    {
        public string Odatametadata { get; set; }
        public BusStopsODPVDetails[] BusStopsODPVDetails { get; set; }
    }
    public class BusStopsODPVDetails
    {
        public string Link { get; set; }
    }

}
