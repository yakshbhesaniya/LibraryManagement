using LibraryManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;using System.Threading.Tasks;

namespace LibraryManagement.Domain.Entities
{
    public class Book
    {
        public Book() { }
        public Book(string title, Guid authorId, Guid publisherId, Publication publication)
        {
            Title = title;
            AuthorId = authorId;
            PublisherId = publisherId;
            Publication = publication;
        }

        public Guid Id { get; set; }
        public string Title { get; private set; }
        public Guid AuthorId { get; private set; }
        public Guid PublisherId { get; private set; }
        public Publication Publication { get; private set; }
        public virtual Author Author { get; private set; }
        public virtual Publisher Publisher { get; private set; }   
    }
}
