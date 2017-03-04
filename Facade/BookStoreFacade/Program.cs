using BookStoreFacade.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreFacade
{
    class Program
    {
        static void Main(string[] args)
        {
            Facade facade = new Facade();

            Console.Write("Input ISBN: ");
            int isbn = int.Parse(Console.ReadLine());

            Client client = new Client("John Doe", "john@mail.com");

            facade.SellBook(isbn, client);
        }
    }
}
