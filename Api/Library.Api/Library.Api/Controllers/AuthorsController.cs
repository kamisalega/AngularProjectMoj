using System;
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
            try
            {
                
                var authorsFromRepo = _libraryRepository.GetAuthors();
            
                var authors = _mapper.Map<IEnumerable<AuthorDto>>(authorsFromRepo);

                return Ok(authors);
            }
            catch (Exception)
            {
                return StatusCode(500, "Wydażył się nieoczekiwany błąd. Spróbuj później.");
            }            
           
        }

        [HttpGet("{id}")]
        public IActionResult GeTAuthor(Guid id)
        {
            
            var authorFromRepo = _libraryRepository.GetAuthor(id);

            if (authorFromRepo == null)
            {
                return NotFound();
            }

            var author = _mapper.Map<AuthorDto>(authorFromRepo);

            return Ok(author);
        }
    }
    
}