var builder = WebApplication.CreateBuilder(args);

//VAMOS A AÑADIR LOS SERVICIOS DE VISTAS Y CONTROLADORES
builder.Services.AddControllersWithViews();

var app = builder.Build();

//DEBEMOS INDICAR AL SERVIDOR QUE SISTEMA DE RUTAS UTILIZARA
//HTTPS://SERVIDOR/CONTROLLER/VISTA
//app.MapGet("/", () => "Hello World!");
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}"
    );

app.Run();
