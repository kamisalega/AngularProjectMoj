using System.ComponentModel.DataAnnotations;
using Library.Api.Models;

namespace Library.Api.ValidationAttributes
{
    public class BookValidationAttributes : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var book = (BookForCreationDto) validationContext.ObjectInstance;
            if (book.Title == book.Description)
            {
                return new ValidationResult
                (
                    "The provided description should be different from the title.", new[] {nameof(BookForCreationDto)}
                );
            }

            return ValidationResult.Success;
        }
    }
}