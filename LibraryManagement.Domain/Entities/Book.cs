using LibraryManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;using System.Threading.Tasks;

namespace LibraryManagement.Domain.Entities
{
    public class Book
    {
        //public Book() { }
        //public Book(string title, Guid authorId, Guid publisherId, Publication publication)
        //{
        //    BookTitle = title;
        //    AuthorId = authorId;
        //    PublisherId = publisherId;
        //    Publication = publication;
        //}

        public Guid BookId { get; set; }
        public string BookTitle { get; set; }
         public Guid PublisherId { get;  set; }

        public Guid PublicationId { get;  set; }
         public Publication Publication { get; set; }
         public virtual Author Author { get; set; }
         public virtual Publisher Publisher { get; set; }   
    }
}
