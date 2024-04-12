using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using COMP003B.Assignment3_.Data;

var builder = WebApplication.CreateBuilder(args);

// Register the database context
builder.Services.AddDbContext<COMP003BAssignment3_Context>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("COMP003BAssignment3_Context") ?? throw new InvalidOperationException("Connection string 'COMP003BAssignment3_Context' not found.")));

// Add services to the container.
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

// Set up the default route
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=product}/{action=Index}/{id?}");

app.Run();

