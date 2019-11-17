
using Library.Api.Helpers;
using Microsoft.CodeAnalysis;

namespace Library.Api.Entities.Profile
{
    public class AuthorMappingProfile : AutoMapper.Profile
    {
        public AuthorMappingProfile()
        {
            CreateMap<Entities.Author, Models.AuthorDto>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => $"{src.FirstName} {src.LastName}"))
                .ForMember(dest => dest.Age, opt => opt.MapFrom(src => src.DateOfBirth.GetCurrentAge()));

            CreateMap<Models.AuthorForCreationDto, Entities.Author>();
        }   
    }
}