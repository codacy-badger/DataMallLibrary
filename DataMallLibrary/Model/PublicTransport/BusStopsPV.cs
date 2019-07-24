using System;
using System.Collections.Generic;
using System.Text;

namespace DataMallLibrary.Model.PublicTransport
{
    public class BusStopPV
    {
        public string Odatametadata { get; set; }
        public BusStopPVDetails[] BusStopPVDetails { get; set; }
    }

    public class BusStopPVDetails
    {
        public string Link { get; set; }
    }
}