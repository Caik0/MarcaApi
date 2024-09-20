using MarcaApi.Data;
using MarcaApi.Models;  // Certifique-se de que este namespace está sendo importado
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddDbContext<MarcaApiContext>();


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Marca API V1");
    });
}

app.MapGet("/marcas", async (MarcaApiContext db) => await db.Marcas.ToListAsync());

app.MapGet("/marcas/{id}", async (int id, MarcaApiContext db) =>
    await db.Marcas.FindAsync(id) is Marca marca
        ? Results.Ok(marca)
        : Results.NotFound());

app.MapPost("/marcas", async (Marca marca, MarcaApiContext db) =>
{
    db.Marcas.Add(marca);
    await db.SaveChangesAsync();
    return Results.Created($"/marcas/{marca.Id}", marca);
});

app.MapPut("/marcas/{id}", async (int id, Marca updatedMarca, MarcaApiContext db) =>
{
    var marca = await db.Marcas.FindAsync(id);
    if (marca is null) return Results.NotFound();

    marca.Nome = updatedMarca.Nome;
    marca.AnoFundacao = updatedMarca.AnoFundacao;
    marca.PaisOrigem = updatedMarca.PaisOrigem;
    marca.Setor = updatedMarca.Setor;
    marca.Slogan = updatedMarca.Slogan;
    marca.Website = updatedMarca.Website;
    marca.Descricao = updatedMarca.Descricao;

    await db.SaveChangesAsync();
    return Results.NoContent();
});

app.MapDelete("/marcas/{id}", async (int id, MarcaApiContext db) =>
{
    var marca = await db.Marcas.FindAsync(id);
    if (marca is null) return Results.NotFound();

    db.Marcas.Remove(marca);
    await db.SaveChangesAsync();
    return Results.Ok(marca);
});

app.Run();
