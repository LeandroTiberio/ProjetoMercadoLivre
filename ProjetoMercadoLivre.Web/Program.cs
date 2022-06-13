using ProjetoMercadoLivre.Lib.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.NewtonsoftJson;
using ProjetoMercadoLivre.Lib.Data.Repositorios;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.

builder.Services.AddDbContext<MercadoLivreContext>
(conn => conn.UseNpgsql(builder.Configuration.GetConnectionString("MercadoLivreDb"))
    .UseLowerCaseNamingConvention());
                
builder.Services.AddControllers()
                .AddNewtonsoftJson(x => x.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<ProdutoRepositorio>();
builder.Services.AddScoped<PedidoRepositorio>();
builder.Services.AddScoped<TransportadoraRepositorio>();
builder.Services.AddScoped<UsuarioRepositorio>();
builder.Services.AddScoped<VendedoresRepositorio>();
builder.Services.AddScoped<ProdutoXPedidoRepositorio>();
builder.Services.AddScoped<IProdutoRepositorio, ProdutoRepositorio>();
builder.Services.AddScoped<IPedidoRepositorio, PedidoRepositorio>();
builder.Services.AddScoped<IProdutoXPedidoRepositorio, ProdutoXPedidoRepositorio>();
builder.Services.AddScoped<ITransportadoraRepositorio, TransportadoraRepositorio>();
builder.Services.AddScoped<IUsuarioRepositorio, UsuarioRepositorio>();
builder.Services.AddScoped<IVendedoresRepositorio, VendedoresRepositorio>();

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
