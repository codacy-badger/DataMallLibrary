using System;
using System.Collections.Generic;
using System.Text;

namespace DataMallLibrary.Model.PublicTransport
{

    public class BusServices
    {
        public string odatametadata { get; set; }
        public BusServicesDetails[] BusServicesDetails { get; set; }
    }

    public class BusServicesDetails
    {
        public string ServiceNo { get; set; }
        public string Operator { get; set; }
        public int Direction { get; set; }
        public string Category { get; set; }
        public string OriginCode { get; set; }
        public string DestinationCode { get; set; }
        public string AM_Peak_Freq { get; set; }
        public string AM_Offpeak_Freq { get; set; }
        public string PM_Peak_Freq { get; set; }
        public string PM_Offpeak_Freq { get; set; }
        public string LoopDesc { get; set; }
    }
}
