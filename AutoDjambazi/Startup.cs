using AutoDjambazi.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<DatabaseContext>(options => 
{
    options.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=Mobiphony;Trusted_Connection=True;TrustServerCertificate=True;");
});

var app = builder.Build();

app.UseStaticFiles();

if(app.Environment.IsDevelopment())
    app.UseDeveloperExceptionPage();

app.MapDefaultControllerRoute();

app.Run();
