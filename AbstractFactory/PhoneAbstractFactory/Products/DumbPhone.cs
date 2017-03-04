using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneAbstractFactory.Products
{
    public abstract class DumbPhone
    {
        public virtual void DoSomething()
        {
            Console.WriteLine("Zun zun");
        }
    }
}
