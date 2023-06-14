using Microsoft.EntityFrameworkCore;
using CursosOnline.Infraestructure.Context;
using CursosOnline.IOC.Dependencies;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//"App Dependencies"

builder.Services.AddContextDependency(builder.Configuration.GetConnectionString("CursosContext"));

builder.Services.AddAlmacenDependency();

//end


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
