using Microsoft.EntityFrameworkCore;
using Modelos.DataAccess.Context;
using Modelos.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Register interface and class which we injected

// Register interface and classes
builder.Services.AddScoped<ICliente, ClienteImpl>();
builder.Services.AddScoped<ICondicion, CondicionImpl>();
builder.Services.AddScoped<IFormaPago, FormaPagoImpl>();
builder.Services.AddScoped<IInMueble, InmuebleImpl>();
builder.Services.AddScoped<ITipoInmueble, TipoInmuebleImpl>();
builder.Services.AddScoped<IVenta, VentaImpl>();

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<ApplicationDbContext>(
       options => options.UseSqlServer(builder.Configuration.GetConnectionString("Conexion")));
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
