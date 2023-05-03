using LibraryManagement.Application.Interfaces;
using LibraryManagement.Application.Services;
using LibraryManagement.Infrastructure.Data;
using LibraryManagement.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// Book Services
builder.Services.AddScoped<IBookService, BookService>();
builder.Services.AddScoped<IBookRepository, BookRepository>();

//Author Services
builder.Services.AddScoped<IAuthorService, AuthorService>();
builder.Services.AddScoped<IAuthorRepository, AuthorRepository>();

//Publication Services
builder.Services.AddScoped<IPublicationService, PublicationService>();
builder.Services.AddScoped<IPublicationRepository, PublicationRepository>();

//Publisher
builder.Services.AddScoped<IPublisherService, PublisherService>();
builder.Services.AddScoped<IPublisherRepository, PublisherRepository>();


builder.Services.AddControllers();
builder.Services.AddDbContext<ApplicationDBContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});
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

app.UseRouting();

app.UseAuthorization();

app.MapControllers();

app.Run();
