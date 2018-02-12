using OrderPizza.Classes;
using OrderPizza.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OrderPizza.Data
{
    public class PizzaManager
    {
        IPizzaService _pizzaService;

        public PizzaManager(IPizzaService pizzaService)
        {
            _pizzaService = pizzaService;
        }

        public Task<List<Item>> GetPizzaAsync()
        {
            return _pizzaService.GetPizzasAsync();
        }

    }
}
