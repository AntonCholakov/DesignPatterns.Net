using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaptopSimpleFactoryMethod
{
    public abstract class Laptop
    {
        public virtual void TurnOn()
        {
            Console.WriteLine("Laptop is on.");
        }

        public virtual void TurnOff()
        {
            Console.WriteLine("Laptop is off.");
        }
    }
}
