using PhoneAbstractFactory.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneAbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            IPhoneFactory samsungFactory = new SamsungFactory();
            IPhoneFactory nokiaFactory = new NokiaFactory();

            var samsungSmartPhone = samsungFactory.GetSmartPhone();
            var samsungDumbPhone = samsungFactory.GetDumbPhone();
            var nokiaSmartPhone = nokiaFactory.GetSmartPhone();
            var nokiaDumbPhone = nokiaFactory.GetDumbPhone();

            samsungSmartPhone.DoSomething();
            samsungDumbPhone.DoSomething();
        }
    }
}
