using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

 
app.MapGet("api/info", () =>
{
    var response = new
    {
        Email = "tolulopejossyp@gmail.com",  
        CurrentDateTime = DateTime.UtcNow.ToString("o"),  
        GitHubUrl = "https://github.com/Opeyemi-Esan/HngLevelZeroProject"
    };

    return Results.Ok(response);
});

app.Run();