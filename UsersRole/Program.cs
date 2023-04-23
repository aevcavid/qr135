using Microsoft.EntityFrameworkCore;
using UsersRole.BLL.Abstract;
using UsersRole.BLL.Concrete;
using UsersRole.BLL.Mapper;
using UsersRole.DAL;
using UsersRole.DAL.Abstract;
using UsersRole.DAL.Concrete;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<MyContext>(options =>
{
    options.UseNpgsql(builder.Configuration.GetConnectionString("AppDb"));
});
builder.Services.AddAutoMapper(typeof(AutoMapperProfiles));
builder.Services.AddScoped<ICountryRepository, CountryRepository>();
builder.Services.AddScoped<ICountryService, CountryService>();
builder.Services.AddScoped<ICityRepository, CityRepository>();
builder.Services.AddScoped<Service, CityService>();


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
