using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaDecorator
{
    class TomatoSauceDecorator : SauceDecorator
    {
        public TomatoSauceDecorator(IPizza pizza) : base(pizza)
        {
        }

        public override string GetDescription()
        {
            return base.GetDescription() + " + Tomato Sauce";
        }

        public override double GetCost()
        {
            return base.GetCost() + 0.25;
        }
    }
}
