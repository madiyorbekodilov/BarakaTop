using AutoMapper;
using BarakaTop.Domain.Entities;
using BarakaTop.Service.DTOs.Group;
using BarakaTop.Service.DTOs.Radar;
using BarakaTop.Service.DTOs.User;

namespace BarakaTop.Service.Mappers;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        // User
        CreateMap<User, UserResultDto>().ReverseMap();
        CreateMap<UserCreationDto, User>().ReverseMap();
        CreateMap<UserUpdateDto, User>().ReverseMap();

        // Group
        CreateMap<Group, GroupResultDto>().ReverseMap();
        CreateMap<GroupCreationDto, Group>().ReverseMap();
        CreateMap<GroupUpdateDto, Group>().ReverseMap();

        // Radar
        CreateMap<Radar, RadarResultDto>().ReverseMap();
        CreateMap<RadarCreationDto, Radar>().ReverseMap();
    }
}
