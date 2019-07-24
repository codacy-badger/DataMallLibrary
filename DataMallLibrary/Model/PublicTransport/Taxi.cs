using System;
using System.Collections.Generic;
using System.Text;

namespace DataMallLibrary.Model.PublicTransport
{
    public class Taxi
    {
        public string Odatametadata { get; set; }
        public TaxiDetails[] TaxiDetails { get; set; }
    }

    public class TaxiDetails
    {
        public float Longitude { get; set; }
        public float Latitude { get; set; }
    }
}
