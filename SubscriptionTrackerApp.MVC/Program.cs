using SubscriptionTrackerApp.Data;
using SubscriptionTrackerApp.Data.Entities;
using SubscriptionTrackerApp.Services.SubscriptionServices;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SubscriptionTrackerApp.Services.SubscriptionFrequencyServices;
using SubscriptionTrackerApp.Services.ServiceServices;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<ISubscriptionUserService, SubscriptionUserService>();
builder.Services.AddScoped<ISubscriptionFrequencyService, SubscriptionFrequencyService>();
builder.Services.AddScoped<IServiceService, ServiceServices>();

//Add connection string and DbContext setup
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<SubscriptionDbContext>(options => options.UseSqlServer(connectionString));

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
