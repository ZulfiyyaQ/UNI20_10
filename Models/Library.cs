using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task14.Models
{
    internal class Library:Base
    {
        List<Book> books;
        static int count;
        public Library(string name):base(name)
        {
            Id = count++;
            Name = name;
        }
        public void AddBook(Book book)
        {
            books.Add(book);
        }
        public  void ListAllBooks()
        {
            foreach (Book book in books)
            {
                Console.WriteLine(books);
            }

        }
    }
}
