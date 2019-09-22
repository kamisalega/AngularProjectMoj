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
            
            return new JsonResult(authorsFromRepo);
        }
    }
    
}