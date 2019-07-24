using DataMallLibrary.Model.PublicTransport;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataMallLibrary.Interfaces
{
    interface IPublicTransport
    {
        Task<BusArrival> GetArrivalDetails(int busStopCode, int ServiceNo = 0);
        Task<BusServices> GetBusServices();
        Task<BusRoutes> GetBusRoutes();
        Task<BusStops> GetBusStops();
        Task<BusStopPV> GetPassengerVolumeByBusStops(DateTime date);
        Task<BusStopsODPV> GetPassengerVolumeByOriginBusStops(DateTime date);
        Task<TrainODPV> GetPassengerVolumeByOriginTrainStations(DateTime date);
        Task<TrainPV> GetPassengerVolumeByTrainStations(DateTime date);
        Task<Taxi> GetAvailableTaxi();
    }
}