using System;
using System.Collections.Generic;
using System.Text;

namespace DataMallLibrary.Model.PublicTransport
{
    public class BusRoutes
    {
        public string Odatametadata { get; set; }
        public BusRoutesDetails[] BusRoutesDetails { get; set; }
    }

    public class BusRoutesDetails
    {
        public string ServiceNo { get; set; }
        public string Operator { get; set; }
        public int Direction { get; set; }
        public int StopSequence { get; set; }
        public string BusStopCode { get; set; }
        public float Distance { get; set; }
        public string WD_FirstBus { get; set; }
        public string WD_LastBus { get; set; }
        public string SAT_FirstBus { get; set; }
        public string SAT_LastBus { get; set; }
        public string SUN_FirstBus { get; set; }
        public string SUN_LastBus { get; set; }
    }

}
