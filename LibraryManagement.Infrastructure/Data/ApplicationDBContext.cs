using LibraryManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Infrastructure.Data
{
    public class ApplicationDBContext : DbContext
    {

        public ApplicationDBContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Author> Author { get; set; }
        public DbSet<Publisher> Publisher { get; set; }
        public DbSet<Book> Book { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.Entity<Team>(e =>
            //{
            //    e.HasMany(t => t.TeamMember).WithMany(u => u.Teams);
            //});

            // Seed Data

            modelBuilder.Entity<Author>().HasData(
                new Author
                {
                    AuthorId = Guid.NewGuid(),
                    AuthorName = "Yaksh"
                });

            modelBuilder.Entity<Designation>().HasData(
                new Designation
                {
                    DesId = Guid.NewGuid(),
                    DesignationName = "Web Developer"
                });

            modelBuilder.Entity<Education>().HasData(
                new Education
                {
                    EduId = Guid.NewGuid(),
                    EducationName = "B.Tech"
                });


        }

    }
}
