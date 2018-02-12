using System;
using System.Collections.Generic;
using System.Text;

namespace OrderPizza.Classes
{
    public class Item
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public double Discount { get; set; }
        public string Description { get; set; }

    }
}
