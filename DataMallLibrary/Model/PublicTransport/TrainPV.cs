using System;
using System.Collections.Generic;
using System.Text;

namespace DataMallLibrary.Model.PublicTransport
{
    public class TrainPV
    {
        public string Odatametadata { get; set; }
        public TrainPVDetails[] TrainPVDetails { get; set; }
    }
    public class TrainPVDetails
    {
        public string Link { get; set; }
    }
}
