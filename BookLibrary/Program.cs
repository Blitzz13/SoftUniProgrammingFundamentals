using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary
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
                DateTime relieseDate = DateTime.ParseExact(tokens.Skip(3).First(),"dd.MM.yyyy",
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

            var authors = lib.books.Select(a => a.Author).Distinct().ToArray();
            var authorSales = new List<AuthorInfo>();
            foreach (var author in authors)
            {
                var sales = lib.books.Where(a => a.Author == author).Sum(a => a.Price);

                authorSales.Add(new AuthorInfo()
                {
                    Author = author,
                    Sales = sales
                });
            }

            authorSales = authorSales.OrderByDescending(a => a.Sales).ThenBy(a => a.Author).ToList();

            foreach (var authorSale in authorSales)
            {
                var author = authorSale.Author;
                var sales = authorSale.Sales;
                Console.WriteLine($"{author} -> {sales:F2}");
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
    class AuthorInfo
    {
        public string Author { get; set; }

        public decimal Sales { get; set; }
    }


}
