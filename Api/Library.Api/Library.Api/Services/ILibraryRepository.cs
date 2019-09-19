using Library.Api.Entities;
using Library.Api.Helpers;

namespace Library.Api.Services
{
    public interface ILibraryRepository
    {
        PagedList<Author> GetAuthors();
    }
}