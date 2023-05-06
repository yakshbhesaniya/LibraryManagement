using LibraryManagement.Application.Interfaces;
using LibraryManagement.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    namespace LibraryManagement.Application.Services
    {
    public class AuthorService : IAuthorService
    {
        private readonly IAuthorRepository authorRepository;

        public AuthorService(IAuthorRepository authorRepository)
        {
            this.authorRepository = authorRepository;
        }

    public async Task<IEnumerable<Author>> GetAll()
    {
        return await authorRepository.GetAll();
    }

    async Task<Author> IAuthorService.GetByAuthorid(Guid Authorid)
    {
        return await authorRepository.GetByAuthorid(Authorid);
    }

    public async Task<Author> AddAuthor(Author author)
    {
        return await authorRepository.AddAuthor(author);
    }

    }
}
