using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FallingMoneyFlyweight
{
    class MetallicMoney : Money
    {
        public MetallicMoney()
        {
            this.MoneyType = MoneyTypeEnum.Metallic;
        }

        public override void DisplayFallingMoney()
        {
            Console.WriteLine();
            Console.WriteLine("   *   ");
            Console.WriteLine(" *   * ");
            Console.WriteLine("*     *");
            Console.WriteLine(" *   * ");
            Console.WriteLine("   *   ");
            Console.WriteLine();
        }
    }
}
