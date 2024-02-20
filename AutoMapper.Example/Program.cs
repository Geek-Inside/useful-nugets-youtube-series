using AutoMapper;
using AutoMapper.Example;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddAutoMapper(typeof(UserProfile));
    
var app = builder.Build();

app.MapGet("/users/{id}", (IMapper mapper) =>
{
    var user = new User("John", "Petrov", "Secret Bunker");
    var userResponse = mapper.Map<UserResponse>(user);
    
    return Results.Ok(userResponse);
});

app.Run();