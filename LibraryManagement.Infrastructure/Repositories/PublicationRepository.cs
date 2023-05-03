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
    public class PublicationRepository : IPublicationRepository
    {
        private readonly ApplicationDBContext db;
        public PublicationRepository(ApplicationDBContext context)
        {
            db = context;
        }

        public async Task<IEnumerable<Publication>> GetAll()
        {
            return await db.Publication.OrderByDescending(b => b.PublicationId).ToListAsync();
        }

        public async Task<Publication> GetByPublicationid(Guid PublicationId)
        {
            return await db.Publication.FindAsync(PublicationId);
        }

        public async Task<Publication> AddPublication(Publication publication)
        {
            await db.Publication.AddAsync(publication);
            await db.SaveChangesAsync();
            return publication;
        }
    }
}
