using Serilog;

var builder = WebApplication.CreateBuilder(args);

builder.Host.UseSerilog((context, config) =>
{
    config.ReadFrom.Configuration(context.Configuration);
});

var app = builder.Build();

app.MapGet("/log", (ILogger<Program> logger) =>
    {
        logger.LogInformation("Hello, Serilog!");
    });

app.Run();