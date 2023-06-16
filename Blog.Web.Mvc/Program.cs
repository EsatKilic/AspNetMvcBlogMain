using App.Business.Services;
using App.Data;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;


namespace App.Web.Mvc
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddDbContext<AppDbContext>(options =>
            {
                var connectionString = builder.Configuration.GetConnectionString("Default");
                options.UseSqlServer(connectionString);
            });

            builder.Services.AddSession(options =>
            {
                options.Cookie.Name = "AuthenticationName";

                // 10 sn tarayýcýda iþlem yapýlmadýðýnda bilgiyi siler
                //options.IdleTimeout = TimeSpan.FromSeconds(10);

                options.Cookie.HttpOnly = true;
                options.Cookie.IsEssential = true;
            });

            builder.Services
               .AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
               .AddCookie(o =>
               {
                   o.Cookie.Name = "AuthenticationName";
                   o.LoginPath = "/Auth/Login";
                   o.AccessDeniedPath = "/Auth/AccessDenied";
               });

            builder.Services.AddControllersWithViews();

            builder.Services.AddScoped<EmailService, EmailService>();
            builder.Services.AddScoped<UserService, UserService>();
  

            builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            var app = builder.Build();

            using (var scope = app.Services.CreateScope())
            {
                // Veritabaný servisine eriþim saðlar.
                var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();

                // Veritabanýný sil
                context.Database.EnsureDeleted();

                // Veritabanýný oluþturur
                context.Database.EnsureCreated();
            }
            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseSession();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.MapControllerRoute(
                name: "areas",
                pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}