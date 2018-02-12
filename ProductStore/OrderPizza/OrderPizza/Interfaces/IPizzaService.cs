using OrderPizza.Classes;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OrderPizza.Interfaces
{
    public interface IPizzaService
    {

        Task<List<Item>> GetPizzasAsync();
    }
}
