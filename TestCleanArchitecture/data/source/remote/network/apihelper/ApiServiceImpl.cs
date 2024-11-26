using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace TestCleanArchitecture.data.source.remote.network.apihelper
{
    public class ApiServiceImpl : ApiService
    {
        private static HttpClient client = new HttpClient()
        {
            BaseAddress = new Uri(Properties.Settings.Default.BaseUrl)
        };

        public async Task<T> get<T>(string url)
        {
            String response = await client.GetStringAsync(url);
            Console.WriteLine(response);
            try
            {
                return JsonSerializer.Deserialize<T>(response);
            }
            catch (Exception ex)
            {
                
                return JsonSerializer.Deserialize<T>(response);
            }
            
        }
    }
}
