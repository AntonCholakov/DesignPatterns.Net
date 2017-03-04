using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaptopFactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            DellFactory dellFactory = new DellFactory();
            AsusFactory asusFactory = new AsusFactory();
            AcerFactory acerFactory = new AcerFactory();

            Laptop dell = dellFactory.CreateLaptop();
            Laptop asus = asusFactory.CreateLaptop();
            Laptop acer = acerFactory.CreateLaptop();
        }
    }
}
