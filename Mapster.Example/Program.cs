using Mapster;
using Mapster.Example;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGet("/users/{id}", () =>
{
    var user = new User("John", "Petrov", "Secret Bunker");
    var userResponse = user.Adapt<UserResponse>();

    return Results.Ok(userResponse);
});

app.Run();