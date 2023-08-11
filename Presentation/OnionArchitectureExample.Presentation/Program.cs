using Microsoft.EntityFrameworkCore;
using OnionArchitectureExample.Application.Abstraction;
using OnionArchitectureExample.Application.Repositories;
using OnionArchitectureExample.Persistence;
using OnionArchitectureExample.Persistence.Contexts;
using OnionArchitectureExample.Persistence.Repositories;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddHttpContextAccessor();

builder.Services.AddPersistenceService();
// Add services to the container.
builder.Services.AddControllers();

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

