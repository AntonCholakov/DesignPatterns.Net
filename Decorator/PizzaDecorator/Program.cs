using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaDecorator
{
    class Program
    {
        static void Main(string[] args)
        {
            IPizza pizza = new Pizza();

            Console.WriteLine("Please, choose a sauce:");
            Console.WriteLine("1 - Tomato sauce");
            Console.WriteLine("2 - Catchup");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Adding Tomato Sauce...");
                    pizza = new TomatoSauceDecorator(pizza);
                    break;
                case 2:
                    Console.WriteLine("Adding Catchup...");
                    pizza = new CatchupDecorator(pizza);
                    break;
            }
            
            Console.WriteLine(pizza.GetDescription());
            Console.WriteLine(pizza.GetCost());
        }
    }
}
