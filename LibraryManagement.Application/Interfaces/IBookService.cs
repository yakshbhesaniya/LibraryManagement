using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Application.Interfaces
{
    internal interface IBookService
    {
        public Task<IEnumerable<Book>> GetAll();
    }
}
