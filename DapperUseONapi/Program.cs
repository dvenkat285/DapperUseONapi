using DapperUseONapi.DapperContext;
using DapperUseONapi.Interface;
using DapperUseONapi.Repo;
using Microsoft.AspNetCore.Components.Authorization;
using System;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddTransient<DapperDbContext>(sp =>
{
    // Assuming DapperDbContext is a custom wrapper for database connection
    var connectionString = builder.Configuration.GetConnectionString("Database");
    return new DapperDbContext(connectionString);
});

// Register repository and services
builder.Services.AddTransient<IDapperService, DapperRepo>();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
