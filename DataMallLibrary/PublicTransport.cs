using System;
using System.Collections.Generic;
using System.Text;
using System.Web;
using DataMallLibrary.Interfaces;
using System.Threading.Tasks;
using DataMallLibrary.Model.PublicTransport;

namespace DataMallLibrary
{
    public class PublicTransport : IPublicTransport
    {
        private readonly Client _client;
        public PublicTransport(Client client)
        {
            _client = client ?? throw new Exception("Client is not instantiated");
        }

        public async Task<BusArrival> GetArrivalDetails(int busStopCode, int ServiceNo = 0)
        {
            var builder = new UriBuilder(APIConstant.PUBLICTRANSPORT_BUSARRIVAL);
            var query = HttpUtility.ParseQueryString(builder.Query);
            query["BusStopCode"] = busStopCode.ToString();
            if (ServiceNo != 0)
            {
                query["ServiceNo"] = ServiceNo.ToString();
            }
            builder.Query = query.ToString();
            return await _client.GetAsync<BusArrival>(builder.Uri).ConfigureAwait(false);
        }

        public async Task<Taxi> GetAvailableTaxi()
        {
            Uri uri = new Uri(APIConstant.PUBLICTRANSPORT_TAXIAVAILABILITY);
            return await _client.GetAsync<Taxi>(uri).ConfigureAwait(false);
        }

        public async Task<BusRoutes> GetBusRoutes()
        {
            Uri uri = new Uri(APIConstant.PUBLICTRANSPORT_BUSROUTES);
            return await _client.GetAsync<BusRoutes>(uri).ConfigureAwait(false);
        }

        public async Task<BusServices> GetBusServices()
        {
            Uri uri = new Uri(APIConstant.PUBLICTRANSPORT_BUSSERVICES);
            return await _client.GetAsync<BusServices>(uri).ConfigureAwait(false);
        }

        public async Task<BusStops> GetBusStops()
        {
            Uri uri = new Uri(APIConstant.PUBLICTRANSPORT_BUSSTOPS);
            return await _client.GetAsync<BusStops>(uri).ConfigureAwait(false);
        }

        public async Task<BusStopPV> GetPassengerVolumeByBusStops(DateTime date)
        {
            throw new NotImplementedException();
        }

        public Task<BusStopsODPV> GetPassengerVolumeByOriginBusStops(DateTime date)
        {
            throw new NotImplementedException();
        }

        public Task<TrainODPV> GetPassengerVolumeByOriginTrainStations(DateTime date)
        {
            throw new NotImplementedException();
        }

        public Task<TrainPV> GetPassengerVolumeByTrainStations(DateTime date)
        {
            throw new NotImplementedException();
        }
    }
}
