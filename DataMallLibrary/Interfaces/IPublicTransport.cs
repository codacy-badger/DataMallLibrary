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
        Task<BusStopPV> GetPassengerVolumeByBusStops(DateTime? date = null);
        Task<BusStopsODPV> GetPassengerVolumeByOriginBusStops(DateTime? date = null);
        Task<TrainODPV> GetPassengerVolumeByOriginTrainStations(DateTime? date = null);
        Task<TrainPV> GetPassengerVolumeByTrainStations(DateTime? date = null);
        Task<Taxi> GetAvailableTaxi();
    }
}