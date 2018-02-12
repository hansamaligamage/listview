using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using OrderPizza.Classes;
using OrderPizza.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace OrderPizza.Services
{
    class PizzaService : IPizzaService
    {

        HttpClient client;
        private string url = "https://pizzastore1.azurewebsites.net/api/item";

        public PizzaService()
        {
            client = new HttpClient();
            client.MaxResponseContentBufferSize = 256000;
        }

        public async Task<List<Item>> GetPizzasAsync()
        {
            List<Item> pizza = new List<Item>();
            var uri = new Uri(string.Format(url, string.Empty));
            try
            {
                var response = await client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    pizza = JsonConvert.DeserializeObject<List<Item>>(content);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"ERROR {0}", ex.Message);
            }
            return pizza;
        }
    }
}
