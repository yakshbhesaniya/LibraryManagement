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

namespace LibraryManagement.Infrastructure.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly ApplicationDBContext db;
        public BookRepository(ApplicationDBContext context)
        {
            db = context;
        }

        public async Task<IEnumerable<Book>> GetAll()
        {
            return await db.Book.OrderByDescending(b => b.Id).ToListAsync();
        }

    }
}
