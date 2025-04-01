    using BalticAbode_Dapper_Api.Models.DapperContext;
using BalticAbode_Dapper_Api.Repositories.AboutRepository;
using BalticAbode_Dapper_Api.Repositories.BottomGridRepository;
using BalticAbode_Dapper_Api.Repositories.CategoryRepository;
using BalticAbode_Dapper_Api.Repositories.ContactRepositories;
using BalticAbode_Dapper_Api.Repositories.EmployeeRepositories;
using BalticAbode_Dapper_Api.Repositories.PopularLocationRepositories;
using BalticAbode_Dapper_Api.Repositories.ProductRepository;
using BalticAbode_Dapper_Api.Repositories.ServiceRepository;
using BalticAbode_Dapper_Api.Repositories.StatisticsRepositories;
using BalticAbode_Dapper_Api.Repositories.TestimonialRepository;
using RealEstate_Dapper_Api.Repositories.PopularLocationRepositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddTransient<Context>();
builder.Services.AddTransient<ICategoryRepository, CategoryRepository>();
builder.Services.AddTransient<IProductRepository, ProductRepository>();
builder.Services.AddTransient<IAboutDetailRepository, AboutDetailRepository>();
builder.Services.AddTransient<IServiceRepository, ServiceRepository>();
builder.Services.AddTransient<IBottomGridRepository, BottomGridRepository>();
builder.Services.AddTransient<IPopularLocationRepository, PopularLocationRepository>();
builder.Services.AddTransient<ITestimonialRepository, TestimonialRepository>();
builder.Services.AddTransient<IEmployeeRepository, EmployeeRepository>();
builder.Services.AddTransient<IStatisticsRepository,StatisticsRepository>();
builder.Services.AddTransient<IContactRepository, ContactRepositiory>();

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
