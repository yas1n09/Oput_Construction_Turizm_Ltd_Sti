using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Authorization;
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

builder.Services.AddMvc(config =>
{
    var policy = new AuthorizationPolicyBuilder()
                   .RequireAuthenticatedUser()
                   .Build();
    config.Filters.Add(new AuthorizeFilter(policy));
});
builder.Services.AddMvc();

//builder.Services.AddAuthentication(
//    CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(x=>
//    {
//        x.LoginPath = "/Login/Index/";
//    });

builder.Services.ConfigureApplicationCookie(options =>
{
    options.Cookie.HttpOnly = true;
    options.ExpireTimeSpan = TimeSpan.FromMinutes(10);
    options.AccessDeniedPath = "/ErrorPage/Index/";
    options.LoginPath = "/Login/Index/";
});





var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseStatusCodePages();

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseAuthentication();

app.UseRouting();

app.UseAuthorization();



app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Default}/{action=Index}/{id?}");

app.Run();


