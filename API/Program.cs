using Core._02_Repositorios.Interfaces;
using Core.Repositorios;
using Core.Repositorios.Data;
using Core.Service;
using Core.Service.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

InicializadorBd.Inicializar();

builder.Services.AddScoped<IEstudanteService, EstudantesService>();

builder.Services.AddScoped<IEstudanteRepository, EstudantesReposity>();

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
