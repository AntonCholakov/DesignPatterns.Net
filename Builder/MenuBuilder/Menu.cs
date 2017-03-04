using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuBuilder
{
    public class Menu
    {
        public string Dish { get; set; }
        public string Drink { get; set; }
        public string Desert { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Drink: " + this.Drink);
            sb.AppendLine("Dish: " + this.Dish);
            sb.AppendLine("Desert: " + this.Desert);

            return sb.ToString();
        }
    }
}
