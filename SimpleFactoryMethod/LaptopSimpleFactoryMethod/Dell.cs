using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaptopSimpleFactoryMethod
{
    public class Dell : Laptop
    {
        public override void TurnOn()
        {
            Console.WriteLine("Dell is on.");
        }
    }
}
