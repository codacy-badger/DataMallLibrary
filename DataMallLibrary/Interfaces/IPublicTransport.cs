using System;
using System.Collections.Generic;
using System.Text;

namespace DataMallLibrary.Interfaces
{
    interface IPublicTransport
    {
        void GetArrivalDetails(int busCode);
        void GetBusServices();
        void GetBusRoutes();
        void GetBusStops();
        void GetPassengerVolumeByBusStops(DateTime date);
        void GetPassengerVolumeByOriginBusStops(DateTime date);
        void GetPassengerVolumeByOriginTrainStations(DateTime date);
        void GetPassengerVolumeByTrainStations(DateTime date);
        void GetAvailableTaxi();
        void GetTrainServiceAlerts();
    }
}
