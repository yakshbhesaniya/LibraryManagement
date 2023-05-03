using LibraryManagement.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Application.Interfaces
{
    public interface IAuthorRepository
    {
        public Task<IEnumerable<Author>> GetAll();
        public Task<Author> GetByAuthorid(Guid AuthorId);

        public Task<Author> AddAuthor(Author author);
    }

}
