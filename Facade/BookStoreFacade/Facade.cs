using BookStoreFacade.Models;
using BookStoreFacade.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreFacade
{
    class Facade
    {
        private List<Book> books;

        private BooksRepository booksRepository;
        private StoreRepository storeRepository;
        private ClientsRepository clientsRepository;

        public Facade()
        {
            this.booksRepository = new BooksRepository();
            this.storeRepository = new StoreRepository();
            this.clientsRepository = new ClientsRepository();

            this.books = new List<Book>();
            books.Add(new Book(1, "First"));
            books.Add(new Book(2, "Second"));
            books.Add(new Book(3, "Third"));
            books.Add(new Book(4, "Fourth"));
            books.Add(new Book(5, "Fifth"));
            books.Add(new Book(6, "Sixth"));
        }

        public void SellBook(int isbn, Client client)
        {
            bool isAvailable = this.booksRepository.CheckAvailability(isbn, this.books);

            if (!isAvailable)
            {
                Console.WriteLine("Book is not available");
                return;
            }

            Book book = this.booksRepository.GetByISBN(isbn, this.books);

            if (book == null)
            {
                Console.WriteLine("Book does not exist");
                return;
            }

            this.clientsRepository.AddToTrolley(client, book);
            this.clientsRepository.Pay(client, book);
            this.storeRepository.UpdateBookList(book, this.books);
            this.clientsRepository.UpdateBookList(client, book);
            this.storeRepository.SendInvoice(client);
        }
    }
}
