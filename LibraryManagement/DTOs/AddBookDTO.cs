using System.ComponentModel.DataAnnotations;

namespace LibraryManagement.API.DTOs
{
    public class AddBookDTO
    {
        [Required] public string BookTitle { get; set; }
        public string AuthorId { get; set; }
        public string PublicationId { get; set; }
        public string PublisherId { get; set; }
    }
}
