using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaDecorator
{
    class CatchupDecorator : SauceDecorator
    {
        public CatchupDecorator(IPizza pizza) : base(pizza)
        {
        }

        public override string GetDescription()
        {
            return base.GetDescription() + " + Catchup";
        }

        public override double GetCost()
        {
            return base.GetCost() + 0.50;
        }
    }
}
