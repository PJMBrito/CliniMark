using CliniMark.Aplication.Interfaces;
using CliniMark.Aplication.Services;
using CliniMark.Infrastructure.Configurations;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.ConfigureModuleInfrastructure(builder.Configuration, typeof(Program).Assembly.FullName);

builder.Services.AddScoped<IService, Service>();


var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
