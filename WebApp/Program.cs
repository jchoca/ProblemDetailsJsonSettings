using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.Configure<JsonOptions>(x =>
{
    x.JsonSerializerOptions.PropertyNamingPolicy = null;
});

var app = builder.Build();

app.MapControllers();

app.Run();