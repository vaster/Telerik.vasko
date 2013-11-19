using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using ASPNET_HW.Models; 

namespace ASPNET_HW.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new HttpClient
            {
                BaseAddress = new Uri("http://localhost:52399/")
            };
            client.DefaultRequestHeaders.Accept.Add(new
                MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response =
                client.GetAsync("api/Music").Result;
            if (response.IsSuccessStatusCode)
            {
                var products = response.Content
                    .ReadAsAsync<IEnumerable<Artist>>().Result;
                foreach (var p in products)
                {
                    Console.WriteLine("{0,4} {1,-20} {2}",
                        p.Name, p.Country);
                }
            }
            else
                Console.WriteLine("{0} ({1})",
                    (int)response.StatusCode, response.ReasonPhrase);

        }
    }
}
