using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuBuilder
{
    public class KinderMenuBuilder : IBuilder
    {
        private Menu menu;

        public KinderMenuBuilder()
        {
            this.menu = new Menu();
        }

        public void AddDesert()
        {
            this.menu.Desert = "Apple";
        }

        public void AddDish()
        {
            this.menu.Dish = "Fish";
        }

        public void AddDrink()
        {
            this.menu.Drink = "Apple juice";
        }

        public Menu GetMenu()
        {
            return this.menu;
        }
    }
}
