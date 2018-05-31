using System;
using System.Collections.Generic;
using System.Text;

namespace PaulCCA.BookLibrary
{
    public class BookJr : Book
    {
        public string Author { get; set; }
        public string Title { get; set; }
        public int Genre { get; set; }

        public string GetFullName()
        {
            return $"{Author} {Title} {Genre}";
        }
    }
}
