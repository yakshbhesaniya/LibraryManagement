using System.ComponentModel.DataAnnotations;

namespace LibraryManagement.API.DTOs
{
    public class AddPublisherDTO
    {
        [Required]
        public string PublisherName { get; set; }
    }
}
