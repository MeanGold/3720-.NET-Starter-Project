var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseDefaultFiles(); // Enables default file mapping, should be used before UseStaticFiles
app.UseStaticFiles(); // Enable serving static files

app.Run();
