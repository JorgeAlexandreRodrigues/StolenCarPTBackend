using Microsoft.EntityFrameworkCore;
using StolenCarPTBackend.Model.Context;
using StolenCarPTBackend.Business;
using StolenCarPTBackend.Business.Implementations;
using StolenCarPTBackend.Repository;
using StolenCarPTBackend.Repository.Generic;
using Microsoft.AspNetCore.Rewrite;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connection = builder.Configuration["MySQLConnection:DefaultConnection"];
string mySqlConnection = builder.Configuration.GetConnectionString("MySQLConnetionString");
builder.Services.AddDbContext<MySqlContext>(options => options.UseMySql(connection, new MySqlServerVersion(new Version(8, 0, 31))));

builder.Services.AddCors(options => options.AddDefaultPolicy(builder =>
{
    builder.AllowAnyOrigin()
    .AllowAnyMethod()
    .AllowAnyHeader();
}));
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
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
    {
        Title = "REST API StolenCarPT",
        Version = "V1",
        Description = "API StolenCarPT",
        Contact = new Microsoft.OpenApi.Models.OpenApiContact
        {
            Name = "Jorge Alexandre Rodrigues && João Rodrigues",
            Url = new Uri("https://github.com/JorgeAlexandreRodrigues")
        }
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{

    app.UseSwagger();
    app.UseSwaggerUI(
        c =>
        {
            c.SwaggerEndpoint("/swagger/v1/swagger.json", "API StolenCarPT - V1");
        });
}

var option = new RewriteOptions();
option.AddRedirect("^$", "swagger");

app.UseRewriter(option);

app.UseHttpsRedirection();

app.UseRouting();

app.UseCors();

app.UseAuthorization();

app.MapControllers();


app.Run();
