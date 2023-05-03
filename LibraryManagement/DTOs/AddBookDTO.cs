using System.ComponentModel.DataAnnotations;

namespace LibraryManagement.API.DTOs
{
    public class AddBookDTO
    {
        [Required] public string BookTitle { get; set; }
        public Guid AuthorId { get; set; }
        public Guid PublicationId { get; set; }
        public Guid PublisherId { get; set; }
    }
}
