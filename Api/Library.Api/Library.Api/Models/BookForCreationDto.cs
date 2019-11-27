using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Library.Api.ValidationAttributes;

namespace Library.Api.Models
{
    [BookValidationAttributes(ErrorMessage = "Title must be different from description")]
    public class BookForCreationDto 
    {
        [Required(ErrorMessage = "You should fill out a title.")] 
        [MaxLength(100, ErrorMessage = "The title shouldn't have more  than 100 characters.")] 
        public string Title { get; set; }
        
        [MaxLength(1500, ErrorMessage = "The description shouldn't have more than 1500 characters.")] 
        public string Description { get; set; }
    }
}