using PhoneAbstractFactory.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneAbstractFactory.Factories
{
    public interface IPhoneFactory
    {
        SmartPhone GetSmartPhone();
        DumbPhone GetDumbPhone();
    }
}
