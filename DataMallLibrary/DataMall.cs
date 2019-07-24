using System;

namespace DataMallLibrary
{
    public class DataMall
    {
        readonly Client _client;
        public ActiveMobility ActiveMobility;
        public PublicTransport PublicTransport;

        public DataMall(string APIKey)
        {
            if (string.IsNullOrEmpty(APIKey))
            {
                throw new ArgumentNullException(nameof(APIKey));
            }
            _client = new Client(APIKey);

            this.ActiveMobility = new ActiveMobility(_client);
            this.PublicTransport = new PublicTransport(_client);
        }
    }
}