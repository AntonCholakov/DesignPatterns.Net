using BookStoreFacade.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreFacade.Repositories
{
    class ClientsRepository
    {
        public void AddToTrolley(Client client, Book book)
        {
            client.Trolley.Add(book);
        }

        public void UpdateBookList(Client client, Book book)
        {
            client.Trolley.Remove(book);
            client.RentedBooks.Add(book);
        }

        public void Pay(Client client, Book book)
        {
            Console.WriteLine("{0} paid for {1}", client.Name, book.Title);
        }
    }
}
