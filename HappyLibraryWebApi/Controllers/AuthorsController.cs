using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using BLL;
using Repositories.Repositories;
using Service;

namespace HappyLibraryWebApi.Controllers
{
    public class AuthorsController : ApiController
    {
        private readonly AuthorService _aS = new AuthorService(); 

        // GET: api/Author
        public IEnumerable<Author> Get()
        {
            return _aS.GetAll();
        }

        // GET: api/Author/5
        public Author GetById(int id)
        {
            return _aS.GetById(id);
        }

        // POST: api/Author
        public void Post([FromBody]Author author)
        {
            _aS.Add(author);
        }

        // PUT: api/Author/5
        public void Put([FromBody]Author author)
        {
            _aS.Update(author);
        }

        // DELETE: api/Author/5
        public void Delete(Author author)
        {
            _aS.Remove(author);
        }
    }
}
