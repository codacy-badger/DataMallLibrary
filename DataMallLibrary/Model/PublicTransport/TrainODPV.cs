using System;
using System.Collections.Generic;
using System.Text;

namespace DataMallLibrary.Model.PublicTransport
{

    public class TrainODPV
    {
        public string Odatametadata { get; set; }
        public TrainODPVDetails[] TrainODPVDetails { get; set; }
    }

    public class TrainODPVDetails
    {
        public string Link { get; set; }
    }

}
