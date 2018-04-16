using System.Data.Entity;
using BLL;

namespace DAL
{
    public class Context : DbContext
    {
        public Context()
            : base("Library")
        {   
        }

        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Book> Books { get; set; }
    }
}
