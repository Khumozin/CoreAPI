using API.Dtos;
using API.Models;
using AutoMapper;

namespace API.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<User, UserForListDto>();
            CreateMap<User, UserForDetailedDto>();
            CreateMap<UserForUpdateDto, User>();
            CreateMap<DependantForUpdate, Dependant>();
            CreateMap<MainMemberForUpdate, MainMember>();
            CreateMap<PackageForUpdate, Package>();
        }
    }
}