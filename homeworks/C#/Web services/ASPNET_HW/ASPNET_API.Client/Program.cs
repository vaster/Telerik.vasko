using ASPNET_HW.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ASPNET_API.Client
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
                var artists = response.Content
                    .ReadAsAsync<IEnumerable<Artist>>().Result;

                foreach (var a in artists)
                {
                    Console.WriteLine("Name:{0}, \n\rCountry:{1}, \n\rDateOfBirth:{2}\n\r\n\r",
                        a.Name, a.Country, a.DateOfBirth.ToString());
                }
            }
            else
                Console.WriteLine("{0} ({1})",
                    (int)response.StatusCode, response.ReasonPhrase);

        }
    }
}
