using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaptopSimpleFactoryMethod
{
    public static class LaptopFactory
    {
        public static Laptop Get(LaptopTypeEnum type)
        {
            switch (type)
            {
                case LaptopTypeEnum.Dell:
                    return new Dell();
                case LaptopTypeEnum.Asus:
                    return new Asus();
                case LaptopTypeEnum.Lenovo:
                    return new Lenovo();
                case LaptopTypeEnum.Acer:
                default:
                    return new Acer();
            }
        }
    }
}
