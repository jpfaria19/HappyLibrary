using System.Collections.Generic;
using BLL;
using Repositories.Repositories;

namespace Service
{
    public class BookService
    {
        private readonly BookRepository _bR = new BookRepository();
        private readonly AuthorRepository _aR = new AuthorRepository();

        public void AddBook(int authorId, Book book)
        {
            //TODO: VERIFICAR SE ADD BOOKS ESTÁ CORRETO PASSANDO REPOSITÓRIO DE AUTHOR.

            _aR.GetById(authorId).Books.Add(book);
            _aR.Ct.SaveChanges();
        }

        public Book GetById(int id)
        {
            return _bR.GetById(id);
        }

        public IEnumerable<Book> GetAll()
        {
            return _bR.GetAll();
        }

        public void Add(Book obj)
        {
            _bR.Add(obj);
        }

        public void Update(Book obj)
        {
            _bR.Update(obj);
        }

        public void Remove(Book obj)
        {
            _bR.Remove(obj);
        }

        public void Dispose()
        {
            _bR.Dispose();
        }
    }
}
