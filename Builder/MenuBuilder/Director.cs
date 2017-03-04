using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuBuilder
{
    public class Director
    {
        public void Construct(IBuilder builder)
        {
            builder.AddDish();
            builder.AddDrink();
            builder.AddDesert();
        }
    }
}
