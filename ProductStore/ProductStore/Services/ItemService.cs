using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductStore.Services
{
    public class ItemService : IItemService
    {
        public List<Item> GetItems()
        {
            List<Item> items = new List<Item>() {
                new Item { Id = 1, Name = "Chicken Bacon", Description = "Chicken bacon, onions & green chillies with a double layer of mozzarella cheese.", Price = 1720 }, 
                new Item { Id = 2, Name = "Devilled Chicken", Description = "Devilled chicken in spicy sauce with a double layer of mozzarella cheese.", Price = 1720 }, 
                new Item { Id = 3, Name = "Butter Chicken Masala",
                    Description = "The ever famous Butter Masala Chicken together with a layer of cream cheese, fresh oinions, coriander, ginger and garlic, blanketed with a layer of Mozzarella cheese"
                    , Price = 1820, Discount = 500 },
                new Item { Id = 4, Name = "Chicken Hawaiian", Description = "Chicken ham & pineapple with a double layer of mozzarella cheese.", Price = 1820 },
                new Item { Id = 5, Name = "Double Chicken & Cheese Fiesta",
                    Description = "A combination  of spicy chicken and kotchchi sausage meat with crunchy onions and jalapenos placed on a layer of cream cheese and a layer of mozzarella.",
                    Price = 1820 },
                new Item { Id = 6, Name = "Teriyaki Chicken Fiesta",
                Description = "Introducing the new Teriyaki Chicken from Pizza Hut! A Pan Pizza with delicious Teriyaki sauce, succulent chicken, crunchy spring onions and topped with mozzarella cheese.",
                    Price = 1820, Discount = 200 } };
            return items;
        }
    }
}
