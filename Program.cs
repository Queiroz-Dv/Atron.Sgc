using Atron.Sgc.Domain.Models;
using Atron.Sgc.Domain.Validador;
using Atron.Sgc.Repositories.Concretes;
using Atron.Sgc.Repositories.Interfaces;
using Atron.Sgc.Services.Concretes;
using Atron.Sgc.Services.Interfaces;
using Atron.Sgc.Services.Validacoes;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

// Aqui estamos o Singleton para fazer os testes em memória
builder.Services.AddSingleton<IRepository<Cliente>, Repository<Cliente>>();
builder.Services.AddSingleton<IClienteRepository, ClienteRepository>();
builder.Services.AddScoped<INotificador, Notificador>();

builder.Services.AddScoped<IClienteService, ClienteService>();
builder.Services.AddScoped<IValidador<Cliente>, ValidadorCliente>();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.MapOpenApi();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapControllers();

app.Run();
