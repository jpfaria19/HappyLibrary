using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BLL;
using Repositories.Repositories;

namespace HappyLibraryWebApi.Controllers
{
    public class BooksController : ApiController
    {
        private readonly BookRepository _bR = new BookRepository();

        // GET: api/Books
        public IEnumerable<Book> Get()
        {
            return _bR.GetAll().ToList();
        }

        // GET: api/Books/5
        public Book GetById(int id)
        {
            return _bR.GetById(id);
        }

        // POST: api/Books
        public void Post([FromBody]Book book)
        {
            _bR.Add(book);
        }

        // PUT: api/Books/5
        public void Put([FromBody]Book book)
        {
            _bR.Update(book);
        }

        // DELETE: api/Books/5
        public void Delete(Book book)
        {
            _bR.Remove(book);
        }
    }
}
