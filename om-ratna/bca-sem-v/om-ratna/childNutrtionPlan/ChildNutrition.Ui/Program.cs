using ChildNutrition.Infrastructure;
using ChildNutrition.Application;
using System.Runtime.CompilerServices;

var builder = WebApplication.CreateBuilder(args);
builder.Configuration.AddJsonFile($"appsetting.Local.json",optional:true, reloadOnChange:true);

// Add services to the container
builder.Services.AddInfrastructure(builder.Configuration);
//Register IAccountService
builder.Services.AddApplication();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
