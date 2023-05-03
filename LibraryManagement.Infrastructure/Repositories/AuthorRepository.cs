using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagement.Application.Interfaces;
using LibraryManagement.Domain.Entities;
using LibraryManagement.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagement.Infrastructure.Repositories
{
    public class AuthorRepository : IAuthorRepository
    {
        private readonly ApplicationDBContext db;
        public AuthorRepository(ApplicationDBContext context)
        {
            db = context;
        }

        public async Task<IEnumerable<Author>> GetAll()
        {
            return await db.Author.OrderByDescending(b => b.AuthorId).ToListAsync();
        }

        public async Task<Author> GetByAuthorid(Guid AuthorId)
        {
            return await db.Author.FindAsync(AuthorId);
        }

        public async Task<Author> AddAuthor(Author author)
        {
            await db.Author.AddAsync(author);
            await db.SaveChangesAsync();
            return author;
        }
    }
}
