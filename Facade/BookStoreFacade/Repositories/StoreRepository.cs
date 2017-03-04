using BookStoreFacade.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreFacade.Repositories
{
    class StoreRepository
    {
        public void UpdateBookList(Book book, List<Book> books)
        {
            books.Remove(book);
        }

        public void SendInvoice(Client client)
        {
            Console.WriteLine("Invoice sent to {0} - {1}", client.Email, client.Name);
        }
    }
}
