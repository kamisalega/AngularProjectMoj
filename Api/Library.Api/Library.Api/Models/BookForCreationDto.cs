using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Library.Api.ValidationAttributes;

namespace Library.Api.Models
{
    [BookValidationAttributes]
    public class BookForCreationDto 
    {
        [Required] 
        [MaxLength(100)] 
        public string Title { get; set; }
        
        [MaxLength(1500)] 
        public string Description { get; set; }
    }
}