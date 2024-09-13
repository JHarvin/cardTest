using MediatR;
using Microsoft.OpenApi.Models;
using WebApi.ApiMapper;
using WebApi.Repository;
using WebApi.Repository.IRepository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Registrar la cadena de conexi�n como Singleton
builder.Services.AddSingleton(sp => builder.Configuration.GetConnectionString("DefaultConnection"));
// Registrar los repositorios que necesiten la cadena de conexi�n
builder.Services.AddScoped<ICompraRepository, CompraRepository >();
builder.Services.AddScoped<IPagoRepository,PagoRepository>();
builder.Services.AddScoped<IClienteRepository, ClienteRepository>();

builder.Services.AddMediatR(typeof(Program).Assembly);
builder.Services.AddControllers();
builder.Services.AddCors();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    // Definir un documento Swagger para el m�dulo Compras
    c.SwaggerDoc("Compras", new OpenApiInfo { Title = "Compras API", Version = "v1" });

  
});
builder.Services.AddAutoMapper(typeof(CardMaper));
var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseHttpsRedirection();
app.UseSwagger();

app.UseSwaggerUI(options => {
    
    options.SwaggerEndpoint("/swagger/Compras/swagger.json", "Compras");
    
});

app.UseRouting();
app.UseHttpsRedirection();

app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
    

});
// soporte para cors
app.UseCors(x => x.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
app.Run();
