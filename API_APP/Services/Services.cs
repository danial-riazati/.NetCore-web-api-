using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace API_APP.Services
{
    public class Services
    {
        protected HttpClient client;
        public void Authentication()
        {
            string baseUrl = "https://the-one-api.dev/v2/";
            //ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            client = new HttpClient();
            client.BaseAddress = new Uri(baseUrl);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
              new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", "mQMIAKAm78n_vfFUFruj");

        }
    }
}
