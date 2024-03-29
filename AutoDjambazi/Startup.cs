using AutoDjambazi.Database;
using AutoDjambazi.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<DatabaseContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddScoped<IPhoneRepository, PhonesRepository>();


var app = builder.Build();

app.UseStaticFiles();

if(app.Environment.IsDevelopment())
    app.UseDeveloperExceptionPage();

app.MapDefaultControllerRoute();
DbInitializer.Seed(app);

app.Run();
