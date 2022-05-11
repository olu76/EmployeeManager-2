using EmployeeManager.RazorPages.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages()
                        .AddRazorPagesOptions(options =>
                        {
                            options.Conventions.AddPageRoute("/EmployeeManager/List", "");
                        });

var ConnectionString = builder.Configuration.GetConnectionString("AppDb");

builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer
(ConnectionString));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{

    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();
app.UseEndpoints(endpoints =>
   {
       endpoints.MapRazorPages();
   });






