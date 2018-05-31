using System;
using System.Collections.Generic;
using System.Text;

namespace PaulCCA.BookLibrary
{
    public class Book
    {
        public int Id { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }

        public string GetFullName()
        {
            return $"{Author} {Title} {Genre}";
        }
    }
}
