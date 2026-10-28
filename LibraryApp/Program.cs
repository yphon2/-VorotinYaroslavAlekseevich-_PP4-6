using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Library lib = new Library();
            lib.AddBook(new Book { Id = 1, Title = "Горе от ума", Author = "Александр Грибоедов" });
            lib.AddBook(new Book { Id = 2, Title = "Идиот", Author = "Федор Достоевский" });

            Console.WriteLine("Выдача существующей книги");
            lib.BorrowBook(1);

            Console.WriteLine("\nВыдача несуществующей книги");
            lib.BorrowBook(99);

            Console.WriteLine("\nПовторная выдача уже выданной книги");
            lib.BorrowBook(1);

            Console.WriteLine("\nВозврат книги, которая не была выдана");
            lib.ReturnBook(2);

            Console.ReadLine();
        }
    }
}
