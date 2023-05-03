using System.ComponentModel.DataAnnotations;

namespace LibraryManagement.API.DTOs
{
    public class AddPublicationDTO
    {
        [Required]
        public int Edition { get; set; }

        [Required]
        public int Year { get; set; }
    }
}
