using System.Collections.Generic;
using BLL;
using Repositories.Repositories;

namespace Service
{
    public class AuthorService
    {
        private readonly AuthorRepository _aR = new AuthorRepository();

        public void AddBook(int authorId, Book book)
        {
            _aR.GetById(authorId).Books.Add(book);
            _aR.Ct.SaveChanges();
        }

        public Author GetById(int id)
        {
            return _aR.GetById(id);
        }

        public IEnumerable<Author> GetAll()
        {
            return _aR.GetAll();
        }

        public void Add(Author obj)
        {
            _aR.Add(obj);
        }

        public void Update(Author obj)
        {
            _aR.Update(obj);
        }

        public void Remove(Author obj)
        {
            _aR.Remove(obj);
        }

        public void Dispose()
        {
            _aR.Dispose();
        }
    }
}
