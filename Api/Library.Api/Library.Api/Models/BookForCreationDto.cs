using System.ComponentModel.DataAnnotations;

namespace Library.Api.Models
{
    public class BookForCreationDto
    {
        [Required] 
        [MaxLength(100)] 
        public string Title { get; set; }
        
        [MaxLength(1500)] 
        public string Description { get; set; }
    }
}