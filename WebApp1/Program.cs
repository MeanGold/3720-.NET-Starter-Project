var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();
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
