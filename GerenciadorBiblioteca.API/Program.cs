using DevFreela.API.ExceptionHandler;
using GerenciadorBiblioteca.API.Services;
using GerenciadorBiblioteca.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<IConfigService, ConfigService>();

//builder.Services.AddDbContext<GerenciadorBibliotecaDbContext>(options => options.UseInMemoryDatabase("GerenciadorBibliotecaDb"));

var connectionString = builder.Configuration.GetConnectionString("GerenciadorBiblioteca");
builder.Services.AddDbContext<GerenciadorBibliotecaDbContext>(options => options.UseSqlServer(connectionString));


builder.Services.AddExceptionHandler<ApiExceptionHandler>();
builder.Services.AddProblemDetails();

// Add services to the container.

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

app.UseExceptionHandler();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
