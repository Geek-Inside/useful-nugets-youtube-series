using Serilog;

/*
dotnet add package Serilog.Sinks.Console
dotnet add package Serilog.Sinks.File
*/

Log.Logger = new LoggerConfiguration()
    .MinimumLevel.Debug()
    .WriteTo.Console()
    .WriteTo.File($"{Environment.CurrentDirectory}/log.txt", rollingInterval: RollingInterval.Day)
    .CreateLogger();

Log.Information("Hello, Serilog!");

Log.CloseAndFlush();