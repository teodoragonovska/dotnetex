var builder = WebApplication.CreateBuilder(args);
using Microsoft.Extensions.Configuration;

// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json");

IConfigurationRoot configuration = builder.Build()

string connectionString= configuration.GetConnectionString("POSTGRESQLConnection")

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
