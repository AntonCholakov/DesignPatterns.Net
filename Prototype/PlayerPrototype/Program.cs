using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerPrototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Player1 player1 = new Player1();
            player1.Name = "John";
            player1.Level = 3;
            player1.Age = 99;
            player1.AdditionalInformation.Money = 200;

            Player1 copy = (Player1)player1.Clone();
            Player1 deepCopy = player1.DeepCopy();

            player1.Level = 4;
            player1.AdditionalInformation.Money = 400;

            Console.WriteLine("Original Player:");
            Console.WriteLine(player1);
            Console.WriteLine();
            Console.WriteLine("Swallow Copy");
            Console.WriteLine(copy);
            Console.WriteLine();
            Console.WriteLine("Deep Copy");
            Console.WriteLine(deepCopy);
        }
    }
}
