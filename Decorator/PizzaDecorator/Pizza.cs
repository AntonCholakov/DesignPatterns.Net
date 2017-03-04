using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaDecorator
{
    class Pizza : IPizza
    {
        public double GetCost()
        {
            return 5;
        }

        public string GetDescription()
        {
            return "Plain Pizza";
        }
    }
}
