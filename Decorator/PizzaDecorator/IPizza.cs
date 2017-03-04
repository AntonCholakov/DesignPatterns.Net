using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaDecorator
{
    interface IPizza
    {
        string GetDescription();
        double GetCost();
    }
}
