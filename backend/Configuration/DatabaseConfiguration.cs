using Infrastructure.DbContexts;

namespace Presentation.Configuration
{
    public static class DatabaseConfiguration
    {
        public static IServiceCollection ConfigureDatabase(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSqlServer<AppDbContext>(configuration.GetConnectionString("DefaultConnection"));

            return services;
        }
    }
}
