var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

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
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "Usuario",
    pattern: "{controller=Usuario}/{action=Index}/{nombre?}");

app.MapControllerRoute(name: "Bienvenida",
                pattern: "Usuario/{nombre}",
                defaults: new { controller = "Usuario", action = "DarBienvenida" });

app.Run();
