using BookStoreFacade.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreFacade.Repositories
{
    class BooksRepository
    {
        public Book GetByISBN(int isbn, List<Book> books)
        {
            return books.FirstOrDefault(b => b.ISBN == isbn);
        }

        public bool CheckAvailability(int isbn, List<Book> books)
        {
            foreach (Book book in books)
            {
                if (book.ISBN == isbn)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
