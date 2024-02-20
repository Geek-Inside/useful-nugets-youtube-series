var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.MapGet("/users", () => new User("John", "Doe"));
app.MapPost("/users", () => Results.Ok());
app.MapDelete("/users", () => Results.Ok());

app.Run();

internal record User (string Name, string Surname);