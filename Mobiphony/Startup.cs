using Mobiphony.Models;
using Microsoft.EntityFrameworkCore;
using MySql.EntityFrameworkCore.Extensions;
using MySqlConnector;
using Mobiphony.Services;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddMySQLServer<DatabaseContext>(builder.Configuration["MySQLCloud"]);
builder.Services.AddDbContext<DatabaseContext>(options => options.UseMySQL(builder.Configuration["MySQLCloud"]));
builder.Services.AddScoped<PhoneRepository>();
builder.Services
    .AddMySqlDataSource(builder.Configuration["MySQLCloud"])
    .AddHealthChecks().AddMySql(
        healthQuery: "SELECT 1;",
        name: "MySQL"
    );
var app = builder.Build();

app.UseStaticFiles();
app.UseHealthChecks("/health");
if(app.Environment.IsDevelopment())
    app.UseDeveloperExceptionPage();
app.MapDefaultControllerRoute();

app.Run();
