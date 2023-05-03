using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Domain.Entities
{
    public class Author 
    {
        //public Author(string name)
        //{
        //    AuthorName = name;
        //    Books = new List<Book>();
        //}

        public Guid AuthorId { get; set; }
        public string AuthorName { get; set; }
      //  public virtual IEnumerable<Book> Books { get; private set; }
    }
}
