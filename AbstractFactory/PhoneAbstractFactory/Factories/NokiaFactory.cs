using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhoneAbstractFactory.Products;

namespace PhoneAbstractFactory.Factories
{
    public class NokiaFactory : IPhoneFactory
    {
        public DumbPhone GetDumbPhone()
        {
            return new Nokia103();
        }

        public SmartPhone GetSmartPhone()
        {
            return new Lumia920();
        }
    }
}
