using LibraryManagement.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Application.Interfaces
{
    public interface IBookService
    {
        public Task<IEnumerable<Book>> GetAll();
        public Task<Book> GetByBookid(Guid id);

        public Task<Book> GetById(Guid id);

        public Task<Book> AddBook(Book book);
        //Task AddBook();
    }
}
