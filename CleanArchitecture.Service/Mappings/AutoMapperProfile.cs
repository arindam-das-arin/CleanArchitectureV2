using AutoMapper;
using CleanArchitecture.DataTransferObject.Dto;
using CleanArchitecture.Entity.Models;

namespace CleanArchitecture.Service.Mappings
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<Role, RoleDto>().ReverseMap();
            CreateMap<UserRole, UserRoleDto>().ReverseMap();
        }
    }
}
