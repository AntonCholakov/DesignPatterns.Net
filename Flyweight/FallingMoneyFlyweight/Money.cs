using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FallingMoneyFlyweight
{
    abstract class Money
    {
        public MoneyTypeEnum MoneyType { get; set; }

        public abstract void DisplayFallingMoney();
    }
}
