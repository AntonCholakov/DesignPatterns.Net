using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaptopFactoryMethod
{
    public class DellFactory : ILaptopFactory
    {
        public Laptop CreateLaptop()
        {
            return new Dell();
        }
    }
}
