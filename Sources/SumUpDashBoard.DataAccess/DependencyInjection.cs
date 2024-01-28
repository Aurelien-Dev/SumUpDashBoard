using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Npgsql;
using SumUpDashBoard.DataAccess;

namespace SumUpDashBoard.DataAccess
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddRepository(this IServiceCollection services)
        {
            //DbContext
            services.AddDbContext<ApplicationDbContext>(options =>
            {
                var cs = $"Host=192.168.1.19;Username=postgres;Password={Environment.GetEnvironmentVariable("PG_PASSWD")};Database=CeramWorkshopAccounting_dev";
                options.UseNpgsql(cs);
            });

            return services;
        }
    }
}