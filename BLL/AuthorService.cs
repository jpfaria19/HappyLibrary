using DAL.Model;
using Repositories;
using System.Collections.Generic;

namespace BLL
{
    public class AuthorService
    {
        private AuthorRepository Ar = new AuthorRepository();

        public void AddBook(int authorId, Book book)
        {
            Ar.GetById(authorId).Books.Add(book);
            Ar.Ct.SaveChanges();
        }

        public Author GetById(int id)
        {
            return Ar.GetById(id);
        }

        public IEnumerable<Author> GetAll()
        {
            return Ar.GetAll();
        }

        public void Add(Author obj)
        {
            Ar.Add(obj);
        }

        public void Update(Author obj)
        {
            Ar.Update(obj);
        }

        public void Remove(Author obj)
        {
            Ar.Remove(obj);
        }

        public void Dispose()
        {
            Ar.Dispose();
        }
    }
}
