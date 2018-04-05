using DAL.Model;
using Repositories;
using System.Collections.Generic;

namespace ApplicationServices
{
    public class BookService
    {
        private BookRepository Br = new BookRepository();
        private AuthorRepository Ar = new AuthorRepository();

        public void AddBook(int AuthorId, Book book)
        {
            Ar.GetById(AuthorId).Books.Add(book);
        }

        public Book GetById(int id)
        {
            return Br.GetById(id);
        }

        public IEnumerable<Book> GetAll()
        {
            return Br.GetAll();
        }

        public void Add(Book obj)
        {
            Br.Add(obj);
        }

        public void Update(Book obj)
        {
            Br.Update(obj);
        }

        public void Remove(Book obj)
        {
            Br.Remove(obj);
        }

        public void Dispose()
        {
            Br.Dispose();
        }
    }
}
