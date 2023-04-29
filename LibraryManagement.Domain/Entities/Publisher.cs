using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Domain.Entities
{
    public class Publisher 
    {
        //public Publisher(string name)
        //{
        //    PublisherName = name;
        //    Books = new List<Book>();
        //}

        public Guid PublisherId { get; set; }
        public string PublisherName { get; set; }
        public virtual IEnumerable<Book> Books { get; set; }
    }
}
