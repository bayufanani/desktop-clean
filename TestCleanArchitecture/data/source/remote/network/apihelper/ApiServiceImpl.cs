using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Policy;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace TestCleanArchitecture.data.source.remote.network.apihelper
{
    internal class ApiServiceImpl: ApiService
    {
        private static HttpClient client = new HttpClient()
        {
            BaseAddress = new Uri(Properties.Settings.Default.BaseUrl)
        };

        public async Task<T> get<T>(string url)
        {
            String response = await client.GetStringAsync(url);
            return JsonSerializer.Deserialize<T>(response);
        }
    }
}
