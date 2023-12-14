using Microsoft.AspNetCore.Mvc;
using TestMapper.Domain;
using TestMapper.Mapper;

namespace TestMapper.Controller;

[ApiController]
[Route("test")]
public class TestController : ControllerBase
{
    private readonly IMapperAdapter _mapperAdapter;

    public TestController(IMapperAdapter mapperAdapter)
    {
        _mapperAdapter = mapperAdapter;
    }

    [HttpGet]
    [Route("create")]
    public IActionResult GetUser()
    {
        var list = new List<User>
        {
            new()
            {
                Id = 1,
                FirstName = "Test",
                LastName = "User 1"
            },
            new()
            {
                Id = 2,
                FirstName = "Test",
                LastName = "User 2"
            }
        };

        var dto = _mapperAdapter.Map<UserDto>(list.First());
        var dtos = _mapperAdapter.ProjectTo<User, UserDto>(list.AsQueryable()).ToList();

        return Ok(dtos);
    }
}