using DataMallLibrary.Interfaces;
using DataMallLibrary.Model.ActiveMobility;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace DataMallLibrary
{
    public class ActiveMobility : IActiveMobility
    {
        private readonly Client _client;

        public ActiveMobility(Client client)
        {
            _client = client ?? throw new Exception("Client is not instantiated");
        }

        async Task<Bicycle> IActiveMobility.GetBicycleParking(double latitude, double longitude, double radius)
        {
            var builder = new UriBuilder(APIConstant.ACTIVEMOBILITY_BICYCLEPARKING);
            var query = HttpUtility.ParseQueryString(builder.Query);
            query["Lat"] = latitude.ToString();
            query["Long"] = longitude.ToString();
            query["Dist"] = radius.ToString();
            builder.Query = query.ToString();

            return await _client.GetAsync<Bicycle>(builder.Uri).ConfigureAwait(false);
        }
    }
}