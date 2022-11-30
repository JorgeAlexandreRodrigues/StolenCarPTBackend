using Microsoft.EntityFrameworkCore;
using StolenCarPTBackend.Model.Context;
using StolenCarPTBackend.Business;
using StolenCarPTBackend.Business.Implementations;
using StolenCarPTBackend.Repository;
using StolenCarPTBackend.Repository.Generic;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connection = builder.Configuration["MySQLConnection:DefaultConnection"];
string mySqlConnection = builder.Configuration.GetConnectionString("MySQLConnetionString");
builder.Services.AddDbContext<MySqlContext>(options => options.UseMySql(connection, new MySqlServerVersion(new Version(8, 0, 31))));

builder.Services.AddControllers();

//Versioning API
builder.Services.AddApiVersioning();

// Dependency Injection
builder.Services.AddScoped<IDistrictsBusiness, DistrictsBusinessImplementations>();
builder.Services.AddScoped<ILocationsBusiness, LocationsBusinessImplementations>();
builder.Services.AddScoped<IBrandsBusiness, BrandsBusinessImplementations>();
builder.Services.AddScoped<IModelsBusiness, ModelsBusinessImplementation>();
builder.Services.AddScoped(typeof(IRepository<>), typeof(GenericRepository<>));

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
