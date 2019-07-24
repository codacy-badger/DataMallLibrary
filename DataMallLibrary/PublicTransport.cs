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
        private Client _client;

        public PublicTransport(Client client)
        {
            _client = client ?? throw new ArgumentNullException("Client is not instantiated");
        }

        public async Task<BusArrival> GetArrivalDetails(int busStopCode, int ? ServiceNo = null)
        {
            var builder = new UriBuilder(APIConstant.PUBLICTRANSPORT_BUSARRIVAL);
            var query = HttpUtility.ParseQueryString(builder.Query);
            query["BusStopCode"] = busStopCode.ToString();
            if (ServiceNo != null)
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

        public async Task<BusStopPV> GetPassengerVolumeByBusStops(DateTime ? date = null)
        {
            var builder = new UriBuilder(APIConstant.PUBLICTRANSPORT_PV_BUSSTOPS);
            var query = HttpUtility.ParseQueryString(builder.Query);
            if (date != null)
            {
                query["Date"] = date.ToString();
            }
            builder.Query = query.ToString();
            return await _client.GetAsync<BusStopPV>(builder.Uri).ConfigureAwait(false);
        }

        public async Task<BusStopsODPV> GetPassengerVolumeByOriginBusStops(DateTime ? date = null)
        {
            var builder = new UriBuilder(APIConstant.PUBLICTRANSPORT_PV_ORGINDESTBUSSTOPS);
            var query = HttpUtility.ParseQueryString(builder.Query);
            if (date != null)
            {
                query["Date"] = date.ToString();
            }
            builder.Query = query.ToString();
            return await _client.GetAsync<BusStopsODPV>(builder.Uri).ConfigureAwait(false);
        }

        public async Task<TrainODPV> GetPassengerVolumeByOriginTrainStations(DateTime ? date = null)
        {
            var builder = new UriBuilder(APIConstant.PUBLICTRANSPORT_PV_ORIGINTRAINSTATIONS);
            var query = HttpUtility.ParseQueryString(builder.Query);
            if (date != null)
            {
                query["Date"] = date.ToString();
            }
            builder.Query = query.ToString();
            return await _client.GetAsync<TrainODPV>(builder.Uri).ConfigureAwait(false);
        }

        public async Task<TrainPV> GetPassengerVolumeByTrainStations(DateTime ? date = null)
        {
            var builder = new UriBuilder(APIConstant.PUBLICTRANSPORT_PV_TRAINSTATIONS);
            var query = HttpUtility.ParseQueryString(builder.Query);
            if (date != null)
            {
                query["Date"] = date.ToString();
            }
            builder.Query = query.ToString();
            return await _client.GetAsync<TrainPV>(builder.Uri).ConfigureAwait(false);
        }
    }
}