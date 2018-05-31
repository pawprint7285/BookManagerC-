using System;
using System.Collections.Generic;
using System.Text;

namespace PaulCCA.BookLibrary
{
    public class BookRepository
    {
        private static List<Book> _books = new List<Book>();
        private static int nextId = 0;

        public List<Book> ListAll()
        {
            return _books;
        }

        public Book GetById(int id)
        {
            return _books.Find(b => b.Id == id);
        }

        public void Add(Book newBook)
        {
            newBook.Id = nextId++;
            _books.Add(newBook);
        }

        public void Edit(Book editBook)
        {
            var origBo = GetById(editBook.Id);

            origBo.Author = editBook.Author;
            origBo.Title = editBook.Title;
            origBo.Genre = editBook.Genre;
        }

        public void Delete(int id)
        {
            var boToDelete = GetById(id);

            _books.Remove(boToDelete);
        }
    }
}
