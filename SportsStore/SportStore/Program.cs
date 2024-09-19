var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStatusCodePages();

app.UseStaticFiles();

app.UseRouting();

//app.UseAuthorization();

app.MapRazorPages();

//app.UseEndpoints(endpoints => { endpoints.MapDefaultControllerRoute(); });

app.Run();
