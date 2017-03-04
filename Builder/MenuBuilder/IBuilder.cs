using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuBuilder
{
    public interface IBuilder
    {
        void AddDish();
        void AddDrink();
        void AddDesert();
        Menu GetMenu();
    }
}
