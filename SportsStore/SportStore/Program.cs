using Microsoft.AspNetCore.Authentication.OAuth.Claims;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SportStore.Models;


var builder = WebApplication.CreateBuilder(args);

string connection = builder.Configuration.GetConnectionString("SportStoreConnection");

builder.Services.AddDbContext<StoreDbContext>(options => options.UseSqlServer(connection));

// добавляем контекст StoreDbContext в качестве сервиса в приложение

// Add services to the container.
//builder.Services.AddRazorPages();
builder.Services.AddControllersWithViews();

builder.Services.AddScoped<IStoreRepository, EFStoreRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseDeveloperExceptionPage();

app.UseStatusCodePages();

app.UseStaticFiles();

app.UseRouting();

//app.UseAuthorization();

//app.MapRazorPages();

app.UseEndpoints(endpoints => { endpoints.MapDefaultControllerRoute(); });

app.Run();
