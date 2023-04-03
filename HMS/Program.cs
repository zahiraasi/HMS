using HMS.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

string connection = builder.Configuration.GetConnectionString("CS");


// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<MVCContext>(Options =>
{
    Options.UseSqlServer(connection);
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Patients}/{action=Create}/{id?}");

app.Run();
