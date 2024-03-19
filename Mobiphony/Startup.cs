using Mobiphony.Database;
using Mobiphony.Models;
using Microsoft.EntityFrameworkCore;
using MySql.EntityFrameworkCore.Extensions;
using MySqlConnector;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

//builder.Services.AddMySQLServer<DatabaseContext>(builder.Configuration.GetConnectionString("MySQLCloud"));
builder.Services.AddMySQLServer<DatabaseContext>(builder.Configuration["MySQLCloud"]);
builder.Services.AddScoped<IPhoneRepository, PhonesRepository>();
builder.Services
    .AddMySqlDataSource(builder.Configuration["MySQLCloud"])
    .AddHealthChecks().AddMySql(
        healthQuery: "SELECT 1;",
        name: "MySQL"
    );

var app = builder.Build();

app.UseStaticFiles();

if(app.Environment.IsDevelopment())
    app.UseDeveloperExceptionPage();

app.MapDefaultControllerRoute();
app.UseHealthChecks("/health");

app.Run();
