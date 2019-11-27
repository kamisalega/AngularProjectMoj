using Library.Api.Helpers;

namespace Library.Api.Entities.Profile
{
    public class BookMappingProfile : AutoMapper.Profile
    {
        public BookMappingProfile()
        {
            CreateMap<Entities.Book, Models.BookDto>();

            CreateMap<Models.BookForCreationDto, Entities.Book>();

            CreateMap<Models.BookForUpdateDto, Entities.Book>();

        }
    }
}