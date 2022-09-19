var builder = WebApplication.CreateBuilder(args);
builder.Services.AddMvc(); //activar mvc como patrón de desarrollo
var app = builder.Build();

app.UseStaticFiles(); //necesario para regresar estilos css
app.UseRouting();
app.UseFileServer();
app.UseEndpoints(endpoints => endpoints.MapDefaultControllerRoute()); // map default 

app.Run();
