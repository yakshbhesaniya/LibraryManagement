﻿using System.ComponentModel.DataAnnotations;

namespace LibraryManagement.API.DTOs
{
    public class AddAuthorDTO
    {
    [Required]
    public string AuthorName { get; set; }
    }
}
