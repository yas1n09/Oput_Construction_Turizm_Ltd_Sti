using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


builder.Services.AddDbContext<Context>();


//builder.Services.AddIdentity<WriterUser, WriterRole>()
//    .AddEntityFrameworkStores<Context>()
//    .AddDefaultTokenProviders();

builder.Services.AddIdentity<WriterUser, WriterRole>(options =>
{
    // Di�er ayarlar buraya gelebilir
    options.User.RequireUniqueEmail = true; // E-posta adreslerinin benzersiz olmas� gerekti�ini belirtir
})
.AddEntityFrameworkStores<Context>(); // DbContext tipinize uygun bir s�n�f kullanmal�s�n�z




builder.Services.AddControllersWithViews();




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
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
