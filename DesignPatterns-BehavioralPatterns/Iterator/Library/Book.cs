using System.Collections.Generic;

namespace Library
{
   public class Book
    {
        public Book()
        {
            this.Authors = new List<string>();
        }

        public string Title { get; set; }
        public int Year { get; set; }
        public List<string> Authors { get;}
    }
}
