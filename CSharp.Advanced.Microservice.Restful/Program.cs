/**
 *  Program.cs
 * 
 *  author   Cristian Hume Henriquez
 *  version  1.0.0
 *  created  2022-11-28
 *  modified 2022-11-28
 */
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

app.Run();

