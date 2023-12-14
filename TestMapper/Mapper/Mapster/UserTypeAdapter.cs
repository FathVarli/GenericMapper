using Mapster;
using TestMapper.Domain;

namespace TestMapper.Mapper.Mapster;

public class UserTypeAdapter 
{
    public UserTypeAdapter()
    {
        TypeAdapterConfig<User, UserDto>
            .NewConfig()
            .Map(dest => dest.FullName, src => $"{src.FirstName} {src.LastName}");
    }
}