using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneAbstractFactory.Products
{
    public abstract class SmartPhone
    {
        public virtual void DoSomething()
        {
            Console.WriteLine("I can do a lot of things and by the way - Zun zun");
        }
    }
}
