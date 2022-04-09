using AniHelper.Application.Handlers;
using AniHelper.Core.Repositories;
using AniHelper.Core.Repositories.Base;
using AniHelper.Infrastructure.Data;
using AniHelper.Infrastructure.Repositories;
using AniHelper.Infrastructure.Repositories.Base;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
//string connectionString = @"Server=(localdb)\MSSQLLocalDB;Database=cacheappdb;Trusted_Connection=True;";
builder.Services.AddDbContext<AnimeContext>(options =>
{
    options.UseInMemoryDatabase("animeDB");
});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddMediatR(typeof(CreateAnimeHandler).GetTypeInfo().Assembly);
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddTransient<IAnimeRepository, AnimeRepository>();

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
