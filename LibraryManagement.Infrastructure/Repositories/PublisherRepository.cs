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
    public class PublisherRepository : IPublisherRepository
    {
        private readonly ApplicationDBContext db;
        public PublisherRepository(ApplicationDBContext context)
        {
            db = context;
        }

        public async Task<IEnumerable<Publisher>> GetAll()
        {
            return await db.Publisher.OrderByDescending(b => b.PublisherId).ToListAsync();
        }

        public async Task<Publisher> GetByPublisherid(Guid PublisherId)
        {
            return await db.Publisher.FindAsync(PublisherId);
        }

        public async Task<Publisher> AddPublisher(Publisher publisher)
        {
            await db.Publisher.AddAsync(publisher);
            await db.SaveChangesAsync();
            return publisher;
        }
    }
}
