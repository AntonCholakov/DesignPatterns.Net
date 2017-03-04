using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            Director director = new Director();

            IBuilder happyMenuBuilder = new HappyMenuBuilder();
            IBuilder kinderMenuBuilder = new KinderMenuBuilder();

            director.Construct(happyMenuBuilder);
            Menu happyMenu = happyMenuBuilder.GetMenu();

            director.Construct(kinderMenuBuilder);
            Menu kinderMenu = kinderMenuBuilder.GetMenu();

            Console.WriteLine(happyMenu);
            Console.WriteLine(kinderMenu);
        }
    }
}
