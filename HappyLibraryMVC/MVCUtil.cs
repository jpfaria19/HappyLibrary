using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;

namespace HappyLibraryMVC
{
    public class MVCUtil
    {
        private const string BASE_API_ADDRESS = "http://localhost:49497/";

        public static HttpClient GetClient(string userToken)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(BASE_API_ADDRESS);
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            //client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", userToken);
            return client;
        }
    }
}