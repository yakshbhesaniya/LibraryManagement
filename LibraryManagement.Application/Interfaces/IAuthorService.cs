using LibraryManagement.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Application.Interfaces
{
    public interface IAuthorService
    {
        public Task<IEnumerable<Author>> GetAll();
        public Task<Author> GetByAuthorid(Guid id);
        public Task<Author> AddAuthor(Author author);
        //Task AddBook();
    }
}
