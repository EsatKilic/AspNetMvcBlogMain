using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using App.Business.Services;
using App.Data;

namespace App.Business
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddBusinessServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>()/*(o =>
            {
                string connectionString = configuration.GetConnectionString("Default");
                o.UseSqlServer(connectionString);
            })*/;
            services.AddTransient<PostService>();
            services.AddTransient<CategoryService>();
            services.AddTransient<PageService>();
            services.AddTransient<SettingService>();
            services.AddTransient<UserService>();
            return services;
        }
        public static void EnsureDeletedAndCreated(IServiceScope scope)
        {
            // Veritabanı servisine erişim sağlar.
            var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();
            // Veritabanını sil
            context.Database.EnsureDeleted();
            // Veritabanını oluşturur
            context.Database.EnsureCreated();

            DbSeed.Seed(context);
        }
    }
}
