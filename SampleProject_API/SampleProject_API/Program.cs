using Microsoft.EntityFrameworkCore;
using DAL;
using RepositoryLayer.RepositoryClass;
using SampleAPI_Core.RepostioryContracts;
using SampleAPI_Core.Entities;
using RepositoryLayer;
using ApplicationLayer.ServicesContracts;
using ApplicationLayer.ServiceClass;
var builder = WebApplication.CreateBuilder(args);


// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddDbContext<SampleApi_DBContext>(options => {
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultDbConnectionString"));
});

builder.Services.AddTransient<ICityRepository<City>, CityRepository>();
builder.Services.AddTransient<IWeatherRepository<Weather>, WeatherRepository>();
builder.Services.AddTransient<ICitySerivce<City>, CityService>();
builder.Services.AddTransient<IWeatherService<Weather>, WeatherService>();

builder.Services.AddTransient<ITaskRepository<Tasks>, TaskRepository>();
builder.Services.AddTransient<IBoardRepository<Board>, BoardRepository>();
builder.Services.AddTransient<ITaskService<SampleAPI_Core.Entities.Tasks>, TaskService>();
builder.Services.AddTransient<IBoardService<Board>, BoardService>();

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
