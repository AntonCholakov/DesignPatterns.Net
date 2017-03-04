using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FallingMoneyFlyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            MoneyFactory factory = new MoneyFactory();

            Random rand = new Random();

            int sum = 0;
            while (sum <= 100000)
            {
                Money moneyObject;

                int val = rand.Next(0, 10);

                if (val < 8)
                {
                    moneyObject = factory.GetMoneyToDisplay(MoneyTypeEnum.Metallic);
                }
                else
                {
                    moneyObject = factory.GetMoneyToDisplay(MoneyTypeEnum.Paper);
                }

                moneyObject.DisplayFallingMoney();
                sum += val;
            }

            Console.WriteLine("Total count of objects created = {0}", MoneyFactory.ObjectCount);
        }
    }
}
