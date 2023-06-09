using Calculadora.Repositorio;
using Calculadora.Repositorio.Interfaces;
using Calculadora.Servicio;
using Calculadora.Servicio.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation(); 

// My services to the container.
builder.Services.AddSingleton<ICalculadoraServicio, CalculadoraServicio>();
builder.Services.AddSingleton<ICalculadoraRepositorio, CalculadoraRepositorio>();
//builder.Services.AddRazorPages().AddRazorRuntimeCompilation();

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
    pattern: "{controller=Principal}/{action=Bienvenido}/{id?}");

app.Run();
