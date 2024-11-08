using GraduationProject.Components;
using GraduationProject.Data;
using MudBlazor.Services;
using Microsoft.EntityFrameworkCore;




var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();
builder.Services.AddMudServices();
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();
builder.WebHost.UseUrls("http://0.0.0.0:2005");
string myPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "wwwroot", "REMS.db");

builder.Services.AddDbContext<AppDbContext>(Option =>
    Option.UseSqlite($"Data Source={myPath}"));
// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
