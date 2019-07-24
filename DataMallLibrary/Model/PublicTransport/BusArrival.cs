using System;
using System.Collections.Generic;
using System.Text;

namespace DataMallLibrary.Model.PublicTransport
{

    public class BusArrival
    {
        public string Odatametadata { get; set; }
        public string BusStopCode { get; set; }
        public Service[] Services { get; set; }
    }

    public class Service
    {
        public string ServiceNo { get; set; }
        public string Operator { get; set; }
        public Nextbus NextBus { get; set; }
        public Nextbus2 NextBus2 { get; set; }
        public Nextbus3 NextBus3 { get; set; }
    }

    public class Nextbus
    {
        public string OriginCode { get; set; }
        public string DestinationCode { get; set; }
        public DateTime EstimatedArrival { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string VisitNumber { get; set; }
        public string Load { get; set; }
        public string Feature { get; set; }
        public string Type { get; set; }
    }

    public class Nextbus2
    {
        public string OriginCode { get; set; }
        public string DestinationCode { get; set; }
        public DateTime EstimatedArrival { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string VisitNumber { get; set; }
        public string Load { get; set; }
        public string Feature { get; set; }
        public string Type { get; set; }
    }

    public class Nextbus3
    {
        public string OriginCode { get; set; }
        public string DestinationCode { get; set; }
        public DateTime EstimatedArrival { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string VisitNumber { get; set; }
        public string Load { get; set; }
        public string Feature { get; set; }
        public string Type { get; set; }
    }

}
