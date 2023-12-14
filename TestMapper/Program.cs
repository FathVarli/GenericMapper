using TestMapper.Mapper;
using TestMapper.Mapper.AutoMapper;
using TestMapper.Mapper.Mapster;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(typeof(Program)); // if you use automapper open it and close mapsterconfig
builder.Services.AddTransient<IMapperAdapter, AutoMapperAdapter>(); // select mapper packages
//MapsterConfig.Configure(); //if you use mapster open it and close automapper di

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapControllers();
app.UseHttpsRedirection();

app.Run();