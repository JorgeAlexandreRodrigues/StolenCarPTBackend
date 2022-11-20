using Microsoft.EntityFrameworkCore;
using StolenCarPTBackend.Model.Context;
using StolenCarPTBackend.Services;
using StolenCarPTBackend.Services.Implementations;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connection = builder.Configuration["MySQLConnection:DefaultConnection"];
string mySqlConnection = builder.Configuration.GetConnectionString("MySQLConnetionString");
builder.Services.AddDbContext<MySqlContext>(options => options.UseMySql(connection, new MySqlServerVersion(new Version(8, 0, 31))));

builder.Services.AddControllers();


// Dependncy Injection
builder.Services.AddScoped<IDistrictsService, DistrictsServiceImplementations>();

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
