using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductStore
{
    public interface IItemService
    {

        List<Item> GetItems();

    }
}
