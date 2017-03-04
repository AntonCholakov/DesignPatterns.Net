using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaptopSimpleFactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Laptop dell = LaptopFactory.Get(LaptopTypeEnum.Dell);
            dell.TurnOn();

            Laptop asus = LaptopFactory.Get(LaptopTypeEnum.Asus);
            asus.TurnOn();
        }
    }
}
