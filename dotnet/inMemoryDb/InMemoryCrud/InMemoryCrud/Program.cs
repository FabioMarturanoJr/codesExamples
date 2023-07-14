using InMemoryCrud.Application.Interface;
using InMemoryCrud.Application.Services;
using InMemoryCrud.AutoMapper;
using InMemoryCrud.Infrastructure.Context;
using InMemoryCrud.Infrastructure.Interface;
using InMemoryCrud.Infrastructure.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Services
builder.Services.AddScoped<IComputadoresServices, ComputadoresServices>();
builder.Services.AddScoped<IComputadoresRepository, ComputadoresRepository>();

//Context
builder.Services.AddDbContext<DataBaseContext>();
builder.Services.AddAutoMapper(typeof(AutoMapperConfig).Assembly);

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
