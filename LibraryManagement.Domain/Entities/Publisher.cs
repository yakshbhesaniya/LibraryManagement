using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Domain.Entities
{
    public class Publisher 
    {
        public Publisher(string name)
        {
            Name = name;
            Books = new List<Book>();
        }

        public Guid Id { get; set; }
        public string Name { get; private set; }
        public virtual IEnumerable<Book> Books { get; private set; }
    }
}
