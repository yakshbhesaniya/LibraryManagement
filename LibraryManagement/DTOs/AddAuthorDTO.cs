using LibraryManagement.Domain.Entities;

namespace LibraryManagement.API.DTOs
{
    public class AddAuthorDTO
    {
        public string AuthorName { get; set; }
        public virtual IEnumerable<Book> Books { get; set; }
    }
}
