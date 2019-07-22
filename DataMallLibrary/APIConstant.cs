using System;
using System.Collections.Generic;
using System.Text;

namespace DataMallLibrary
{
    internal static class APIConstant
    {
        public const string baseURL = "http://datamall2.mytransport.sg/ltaodataservice/";

        #region PUBLICTRANSPORT ENDPOINTS

        public const string PUBLICTRANSPORT_BUSARRIVAL = baseURL + "/BusArrivalv2";
        public const string PUBLICTRANSPORT_BUSSERVICES = baseURL + "/BusServices";
        public const string PUBLICTRANSPORT_BUSROUTES = baseURL + "/BusRoutes";
        public const string PUBLICTRANSPORT_BUSSTOPS = baseURL + "/BusStops";
        public const string PUBLICTRANSPORT_PV_BUSSTOPS = baseURL + "/PV/Bus";
        public const string PUBLICTRANSPORT_PV_ORGINDESTBUSSTOPS = baseURL + "/PV/ODBus";
        public const string PUBLICTRANSPORT_PV_ORIGINTRAINSTATIONS = baseURL + "/PV/ODTrain";
        public const string PUBLICTRANSPORT_PV_TRAINSTATIONS = baseURL + "/PV/Train";
        public const string PUBLICTRANSPORT_TAXIAVAILABILITY = baseURL + "/Taxi-Availability";
        public const string PUBLICTRANSPORT_TRAINSERVICEALERTS = baseURL + "/TrainServiceAlerts";

        #endregion

        #region TRAFFIC ENDPOINTS
        #endregion

        #region ACTIVEMOBILITY ENDPOINTS

        public const string ACTIVEMOBILITY_BICYCLEPARKING = baseURL + "/BicycleParkingv2";

        #endregion
    }
}