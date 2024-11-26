using Microsoft.EntityFrameworkCore;
using WebApp1.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();
builder.Services.AddDbContext<TigerTixContext>(cfg =>
{
    cfg.UseSqlServer();
});
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IEventRepository, EventRepository>();
builder.Services.AddControllers();
var app = builder.Build();
if (!app.Environment.IsDevelopment()) {
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseDefaultFiles(); // Enables default file mapping, should be used before UseStaticFiles
app.UseHttpsRedirection();
app.UseStaticFiles(); // Enable serving static files


app.UseRouting();
app.UseAuthorization();

app.MapRazorPages();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=App}/{action=Index}/{id?}");
app.Run();
