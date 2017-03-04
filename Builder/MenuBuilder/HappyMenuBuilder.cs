using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuBuilder
{
    public class HappyMenuBuilder : IBuilder
    {
        private Menu menu;

        public HappyMenuBuilder()
        {
            this.menu = new Menu();
        }

        public void AddDesert()
        {
            this.menu.Desert = "Choco Cake";
        }

        public void AddDish()
        {
            this.menu.Dish = "Chicken Burger";
        }

        public void AddDrink()
        {
            this.menu.Drink = "Coca Cola";
        }

        public Menu GetMenu()
        {
            return this.menu;
        }
    }
}
