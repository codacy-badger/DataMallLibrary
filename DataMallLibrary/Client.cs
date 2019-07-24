using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using System.Net;
using Newtonsoft.Json;

namespace DataMallLibrary
{
    public class Client
    {
        private readonly string APIKey;

        public Client(string APIKey)
        {
            this.APIKey = APIKey ?? throw new ArgumentNullException(nameof(APIKey));
        }

        private static readonly HttpClient client = new HttpClient();

        public async Task<T> GetAsync<T>(Uri uri)
        {
            var jsonResult = await GetJsonAsync(uri).ConfigureAwait(false);
            if (jsonResult != null)
            {
                return JsonConvert.DeserializeObject<T>(jsonResult);
            }
            return default;
        }


        public async Task<string> GetJsonAsync(Uri url)
        {
            if (url == null)
            {
                throw new ArgumentNullException(nameof(url));
            }

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Add("AccountKey", this.APIKey);

            var response = await client.GetAsync(url).ConfigureAwait(false);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                return await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            }
            return null;
        }
    }
}