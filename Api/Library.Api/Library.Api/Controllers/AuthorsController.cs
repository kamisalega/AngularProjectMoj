using System.Collections;
using System.Collections.Generic;
using AutoMapper;
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
        private readonly IMapper _mapper;
        
        public AuthorsController(ILibraryRepository libraryRepository, IMapper mapper)
        {
            _libraryRepository = libraryRepository;
            _mapper = mapper;
        }
        
        
        [HttpGet()]
        public IActionResult GetAuthors()
        {
            var authorsFromRepo = _libraryRepository.GetAuthors();
            
            var authors = _mapper.Map<IEnumerable<AuthorDto>>(authorsFromRepo);

            return Ok(authors);
        }
    }
    
}