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
    public class BookRepository : IBookRepository
    {
        private readonly ApplicationDBContext db;
        public BookRepository(ApplicationDBContext context)
        {
            db = context;
        }

        public async Task<IEnumerable<Book>> GetAll()
        {
            return await db.Book.OrderByDescending(b => b.BookId).ToListAsync();
        }

        public async Task<Book> GetByBookid(Guid BookId)
        {
            return await db.Book.FindAsync(BookId);
        }

        public async Task<Book> AddBook(Book book)
        {
            await db.Book.AddAsync(book);
            return book;
        }
    }
}
