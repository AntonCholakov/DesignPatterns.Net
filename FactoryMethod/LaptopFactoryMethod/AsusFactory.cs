using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaptopFactoryMethod
{
    public class AsusFactory : ILaptopFactory
    {
        public Laptop CreateLaptop()
        {
            return new Asus();
        }
    }
}
