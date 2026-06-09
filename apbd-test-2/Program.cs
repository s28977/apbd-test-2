using apbd_test_2.Data;
using apbd_test_2.Services;
using Microsoft.EntityFrameworkCore;
using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration
    .GetConnectionString("DefaultConnection");

// Add services to the container.

builder.Services.AddDbContext<BooksDbContext>(options => 
    options.UseSqlServer(connectionString));

builder.Services.AddScoped<IBorrowingsService, BorrowingService>();
builder.Services.AddScoped<IMembersService, MembersService>();

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.MapScalarApiReference();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();