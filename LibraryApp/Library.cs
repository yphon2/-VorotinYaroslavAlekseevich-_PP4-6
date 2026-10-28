using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp
{
    public class Library
    {
        public List<Book> _books = new List<Book>();

        public void AddBook(Book book)
        {
            _books.Add(book);
        }

        public void BorrowBook(int id)
        {
            var book = _books.FirstOrDefault(b => b.Id == id);

            if (book == null)
            {
                Console.WriteLine("Ошибка: Книга не найдена.");
                return;
            }

            if (book.IsAvailable)
            {
                book.IsAvailable = false;
                Console.WriteLine($"Книга '{book.Title}' выдана.");
            }
            else
            {
                Console.WriteLine("Ошибка: Книга уже выдана.");
            }
        }

        public void ReturnBook(int id)
        {
            var book = _books.FirstOrDefault(b => b.Id == id);

            if (book == null)
            {
                Console.WriteLine("Ошибка: Книга не найдена.");
                return;
            }
            if (book.IsAvailable)
            {
                Console.WriteLine("Ошибка: Эту книгу не выдавали.");
                return;
            }

            book.IsAvailable = true;
            Console.WriteLine($"Книга '{book.Title}' возвращена.");
        }

        public Book FindBook(int id)
        {
            return _books.FirstOrDefault(b => b.Id == id);
        }
    }
}
