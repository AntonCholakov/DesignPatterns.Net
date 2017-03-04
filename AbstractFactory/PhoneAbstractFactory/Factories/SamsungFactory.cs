using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhoneAbstractFactory.Products;

namespace PhoneAbstractFactory.Factories
{
    public class SamsungFactory : IPhoneFactory
    {
        public DumbPhone GetDumbPhone()
        {
            return new GuruPlus();
        }

        public SmartPhone GetSmartPhone()
        {
            return new GalaxyS7();
        }
    }
}
