using System;
using System.Collections;
using System.Collections.Generic;
using AutoMapper;
using Library.Api.Models;
using Library.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace Library.Api.Controllers
{
    [Route("api/authors")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {

        private ILibraryRepository _libraryRepository;
        private readonly IMapper _mapper;
        
        public AuthorsController(ILibraryRepository libraryRepository, IMapper mapper)
        {
            _libraryRepository = libraryRepository ?? throw new ArgumentNullException(nameof(libraryRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
        
        
        [HttpGet()]
        public ActionResult<IEnumerable<AuthorDto>> GetAuthors()
        {
                var authorsFromRepo = _libraryRepository.GetAuthors();
            
                var authors = _mapper.Map<IEnumerable<AuthorDto>>(authorsFromRepo);

                return Ok(authors);
        }

        [HttpGet("{id}")]
        public ActionResult GetAuthor(Guid id)
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