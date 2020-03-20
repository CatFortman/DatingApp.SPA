using System.Linq;
using AutoMapper;
using DatingApp.API.Dtos;
using DatingApp.API.Models;

namespace DatingApp.API.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<User, UserForListDTO>()
                .ForMember(destination => destination.PhotoUrl, options =>
                options.MapFrom(src => src.Photos.FirstOrDefault(p => p.IsMain).Url))
                .ForMember(destination => destination.Age, options => options.MapFrom(src => src.DateOfBirth.CalculateAge()));
                
            CreateMap<User, UserForDetailedDTO>()
                .ForMember(destination => destination.PhotoUrl, options =>
                options.MapFrom(src => src.Photos.FirstOrDefault(p => p.IsMain).Url))
                .ForMember(destination => destination.Age, options => options.MapFrom(src => src.DateOfBirth.CalculateAge()));

            CreateMap<Tag, TagForDetailedDTO>();

            CreateMap<Photo, PhotosForDetailedDTO>();            
            CreateMap<Photo, PhotoForReturnDTO>();
            CreateMap<PhotoForCreationDTO, Photo>();
            
            CreateMap<UserForUpdateDTO, User>();

            
        }
    }
}