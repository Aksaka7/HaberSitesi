using Business.Abstract;
using Business.Base;
using DataAccess.Absract.Repository;
using DataAccess.Base.Repository;
using DataAccess.Context;
using Microsoft.EntityFrameworkCore;
using Shared.Entities;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//DB'ye Baglanýyorum
builder.Services.AddDbContext<HaberContext>(opt => opt.UseSqlServer("Server=DESKTOP-587BMV3\\EXPRESSMEHMET;Database=HaberSitesi;Trusted_Connection=True;TrustServerCertificate=true;"));

//Yaþam dongüsü adý verilen bir olay belirlendi
#region DependencyInjection 
//Data Access Start Burdan baslýyor
builder.Services.AddScoped<DbContext, HaberContext>();
builder.Services.AddScoped<IRepository<Haberler>, Repository<Haberler>>();
builder.Services.AddScoped<IRepository<Kategoriler>, Repository<Kategoriler>>();
builder.Services.AddScoped<IRepository<Slaytlar>, Repository<Slaytlar>>();
builder.Services.AddScoped<IRepository<Yazarlar>, Repository<Yazarlar>>();
builder.Services.AddScoped<IRepository<Yorumlar>, Repository<Yorumlar>>();
//Data Access Finish

//Bussness Start
builder.Services.AddScoped<IHaberService, HaberManager>();
builder.Services.AddScoped<IKategoriService, KategoriManager>();
builder.Services.AddScoped<ISlaytServices, SlaytManager>();
builder.Services.AddScoped<IYazarService, YazarManager>();
builder.Services.AddScoped<IYorumService, YorumManager>();
//Bussness Finish
#endregion

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
