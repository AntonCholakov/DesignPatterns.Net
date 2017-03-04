using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaptopFactoryMethod
{
    public class AcerFactory : ILaptopFactory
    {
        public Laptop CreateLaptop()
        {
            return new Acer();
        }
    }
}
