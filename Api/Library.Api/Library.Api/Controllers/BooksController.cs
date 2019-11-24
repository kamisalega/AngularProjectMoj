using System;
using System.Collections;
using System.Collections.Generic;
using AutoMapper;
using Library.Api.Models;
using Library.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace Library.Api.Controllers
{
    [Route("api/authors/{authorId}/books")]
    [ApiController]
    public class BooksController: ControllerBase
    {
        private ILibraryRepository _libraryRepository; 
        private readonly IMapper _mapper;
        
        
        public BooksController(ILibraryRepository libraryRepository, IMapper mapper)
        {
            _libraryRepository = libraryRepository ?? throw new ArgumentNullException(nameof(libraryRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));

        }
    
        [HttpGet()]
        public ActionResult<IEnumerable<BookDto>> GetBooksForAuthor(Guid authorId)
        {
            if (!_libraryRepository.AuthorExists(authorId))
            {
                return NotFound();
            }

            var booksForAuthorFromRepo = _libraryRepository.GetBooks(authorId);

            var booksForAuthor = _mapper.Map<IEnumerable<BookDto>>(booksForAuthorFromRepo);

            return Ok(booksForAuthor);
        }

        [HttpGet("{id}")]
        public ActionResult GetBookForAuthor(Guid authorId, Guid id)
        {
            if (!_libraryRepository.AuthorExists(authorId))
            {
                return NotFound();
            }
            
            var bookForAuthorFromRepo = _libraryRepository.GetBook(authorId, id);

            if (bookForAuthorFromRepo == null)
            {
                return NotFound();
            }

            var bookForAuthor = _mapper.Map<BookDto>(bookForAuthorFromRepo);

            return Ok(bookForAuthor);
        }
    }
}