using System;
using System.Collections;
using System.Collections.Generic;
using AutoMapper;
using Library.Api.Models;
using Library.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace Library.Api.Controllers
{
    [ApiController]
    [Route("api/authorcollections")]
    public class AuthorCollectionsController : ControllerBase
    {
        private readonly ILibraryRepository _libraryRepository;
        private readonly IMapper _mapper;

        public AuthorCollectionsController(ILibraryRepository libraryRepository, IMapper mapper)
        {
            _libraryRepository = libraryRepository ?? throw new ArgumentNullException(nameof(libraryRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        [HttpPost]
        public ActionResult<IEnumerable<AuthorDto>> CreateAuthorCollection(IEnumerable<AuthorForCreationDto> authorCollection)
        {
            if (authorCollection == null)
            {
                return BadRequest();
            }
            var authorEntities = _mapper.Map<IEnumerable<Entities.Author>>(authorCollection);

            foreach (var author in authorEntities)
            {
                _libraryRepository.AddAuthor(author);
            }
            if (!_libraryRepository.Save())
                throw new Exception("Creating an author failed on save");
            
            return Ok();
        }

    }
}