using AutoMapper;
using UsersRole.DTOs.CountryDTOs;
using UsersRole.DTOs.RoleDTOs;
using UsersRole.DTOs.UserDTOs;
using UsersRole.Model;

namespace UsersRole.BLL.Mapper
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<User, UserToListDto>();
            CreateMap<UserToListDto, User>();
            CreateMap<UserToAddDto, User>();
            CreateMap<User, UserToAddDto>();
            CreateMap<Country, CountryToAddDto>();
            CreateMap<CountryToAddDto, Country>();
            CreateMap<Country, CountryToListDto>();
            CreateMap<CountryToListDto, Country>(); 
            CreateMap<UserToUpdateDto, User>();
            CreateMap<User, UserToUpdateDto>();
            CreateMap<Permission, PermissionToListDto>();
        }

    }
}
