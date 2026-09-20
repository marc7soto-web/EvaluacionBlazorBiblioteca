using BlazorBiblioteca.Components;
using BlazorBiblioteca.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Components;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

// Registra los servicios de Blazor Bootstrap.
builder.Services.AddBlazorBootstrap();

// Habilita el uso de controladores API.
builder.Services.AddControllers();

// Registra el contexto de Entity Framework para conectarse a BibliotecaDB.
builder.Services.AddDbContext<LibroDBContext>(options =>
options.UseSqlServer(
builder.Configuration.GetConnectionString("DefaultConnection")));

// Registra HttpClient para consumir la API del proyecto.
builder.Services.AddScoped(sp =>
{
    var navigationManager =
        sp.GetRequiredService<NavigationManager>();

    return new HttpClient
    {
        BaseAddress = new Uri(navigationManager.BaseUri)
    };
});

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

// Habilita las rutas de los controladores.
app.MapControllers();

app.Run();
