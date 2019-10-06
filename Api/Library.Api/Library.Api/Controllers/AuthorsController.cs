using System.Collections.Generic;
using Library.Api.Helpers;
using Library.Api.Models;
using Library.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace Library.Api.Controllers
{
   [Route("api/authors")]
    public class AuthorsController : Controller
    {

        private ILibraryRepository _libraryRepository;
        
        public AuthorsController(ILibraryRepository libraryRepository)
        {
            _libraryRepository = libraryRepository;
        }
        
        
        [HttpGet()]
        public IActionResult GetAuthors()
        {
            var authorsFromRepo = _libraryRepository.GetAuthors();

            var authors = new List<AuthorDto>();

            foreach (var author in authorsFromRepo)
            {
                authors.Add(new AuthorDto()
                {
                    Id = author.Id,
                    Name = $"{author.FirstName} {author.LastName}",
                    Genere = author.Genre,
                    Age =  DateTimeOffsetExtensions.GetCurrentAge(author.DateOfBirth)
                });
                
                
            }
            
            return new JsonResult(authors);
        }
    }
    
}