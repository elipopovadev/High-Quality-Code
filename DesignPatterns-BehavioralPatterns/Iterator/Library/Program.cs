using System;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library
            {
                new Book {Title = "Whatever", Year = 2015},
                new Book {Title = "Another Book", Year = 2016}
            };

            foreach (var book in library)
            {
                Console.WriteLine(book.Title);
            }
        }
    }
}
