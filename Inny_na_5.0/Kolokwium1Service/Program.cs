using Kolokwium1Storage;
using Kolokwium1Storage.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<StorageDbContext>(options => options.UseInMemoryDatabase("Kolokwium1"));
builder.Services.AddScoped<IUczestnicyService, UczestnicyService>();

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
    pattern: "{controller=Uczestnicy}/{action=Index}/{id?}");

app.Run();
