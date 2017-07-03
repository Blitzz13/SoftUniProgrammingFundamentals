using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibraryModification
{
    class Program
    {
        static void Main(string[] args)
        {
            Library lib = new Library()
            {
                Name = "Библиотека",
                books = new List<Book>()
            };

            int booksCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < booksCount; i++)
            {

                var tokens = Console.ReadLine().Split();

                string title = tokens.First();
                string author = tokens.Skip(1).First();
                string publisher = tokens.Skip(2).First();
                DateTime relieseDate = DateTime.ParseExact(tokens.Skip(3).First(), "dd.MM.yyyy",
                    CultureInfo.InvariantCulture);
                string isbnNumber = tokens.Skip(4).First();
                decimal price = decimal.Parse(tokens.Skip(5).First());

                var book = new Book()
                {
                    Title = title,
                    Author = author,
                    Publisher = publisher,
                    ReleaseDate = relieseDate,
                    Isbn = isbnNumber,
                    Price = price
                };

                lib.books.Add(book);
            }

            DateTime controlDate = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy",
                    CultureInfo.InvariantCulture);
            string format = "dd.MM.yyyy";
            var sortedBooks = lib.books.Where(a => a.ReleaseDate > controlDate).OrderBy(a => a.ReleaseDate).ThenBy(a => a.Title).ToList();
            foreach (var book in sortedBooks)
            {
               
                Console.WriteLine($"{book.Title} -> {book.ReleaseDate.ToString(format)}");
            }

        }
    }
    class Book
    {

        public string Title { get; set; }

        public string Author { get; set; }

        public string Publisher { get; set; }

        public DateTime ReleaseDate { get; set; }

        public string Isbn { get; set; }

        public decimal Price { get; set; }
    }
    class Library
    {
        public string Name { get; set; }

        public List<Book> books { get; set; }
    }
    class BookInfo
    {
        public string Title { get; set; }

        public DateTime ReleaseDate { get; set; }
    }
}
