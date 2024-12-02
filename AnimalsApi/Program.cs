//using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using AnimalsApi.Data;
using Microsoft.EntityFrameworkCore;
var builder = WebApplication.CreateBuilder(args);

var conString = builder.Configuration.GetConnectionString("AnimalsApiContextMySql");
builder.Services.AddDbContext<AnimalsApiContext>(options =>
    options.UseMySql(conString, ServerVersion.AutoDetect(conString)));

//builder.Services.AddDbContext<AnimalsApiContext>(options =>
//    options.UseSqlServer(builder.Configuration.GetConnectionString("AnimalsApiContext") ?? throw new InvalidOperationException("Connection string 'AnimalsApiContext' not found.")));

// Add services to the container.

builder.Services.AddControllers();
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
