using AutoMapper;
using TestMapper.Domain;

namespace TestMapper.Mapper.AutoMapper;

public class UserProfile : Profile
{
    public UserProfile()
    {
        CreateMap<User, UserDto>()
            .ForMember(dest => dest.FullName,
            opt => opt
                .MapFrom((src)
                => $"{src.FirstName} {src.LastName}"));
    }
}