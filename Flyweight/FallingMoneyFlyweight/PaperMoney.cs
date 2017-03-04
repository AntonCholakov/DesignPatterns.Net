using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FallingMoneyFlyweight
{
    class PaperMoney : Money
    {
        public PaperMoney()
        {
            this.MoneyType = MoneyTypeEnum.Paper;
        }
        public override void DisplayFallingMoney()
        {
            Console.WriteLine();
            Console.WriteLine("***********");
            Console.WriteLine("*         *");
            Console.WriteLine("***********");
            Console.WriteLine();
        }
    }
}
