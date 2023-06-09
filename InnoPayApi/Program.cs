using InnoPayApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.EntityFrameworkCore.Design;
using Innovator.Client.Model;
using Innovator.Server;
using InnoPayApi.Repositories.Payment;
using InnoPayApi.Repositories.Interfaces;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("ArasContext");
builder.Services.AddDbContext<ArasContext>(options => options.UseSqlServer(connectionString, options =>
{
    options.EnableRetryOnFailure();
}));
//���URepository��controller
builder.Services.AddScoped(typeof(IRepositoryWrapper), typeof(RepositoryWrapper));

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
