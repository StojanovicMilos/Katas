using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace APIUsageChallenge
{
    public static class Program
    {
        private const string Url = "https://swapi.co/api/";
        private static readonly string urlParameters = "people/1/";

        static void Main()
        {
            using (HttpClient client = InitializeClient())
            {
                HttpResponseMessage response = client.GetAsync(urlParameters).Result;
                if (response.IsSuccessStatusCode)
                {
                    var person = PersonDTO.FromJson(response.Content.ReadAsStringAsync().Result);
                    Console.WriteLine(person.ToString());
                }
                else
                {
                    Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
                }
            }
        }

        private static HttpClient InitializeClient()
        {
            var client = new HttpClient
            {
                BaseAddress = new Uri(Url)
            };
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            return client;
        }
    }
}