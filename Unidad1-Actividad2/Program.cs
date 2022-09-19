var builder = WebApplication.CreateBuilder(args);
builder.Services.AddMvc(); 
var app = builder.Build();

app.UseStaticFiles(); 
app.UseRouting();
app.UseFileServer();
app.UseEndpoints(endpoints => endpoints.MapDefaultControllerRoute());  

app.Run();