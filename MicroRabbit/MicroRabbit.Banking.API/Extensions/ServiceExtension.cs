using MicoRabbit.Infra.IoC;
using MicroRabbit.Banking.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace MicroRabbit.Banking.API.Extensions
{
    public static class ServiceExtension
    {
        public static void ConfigureDbContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<BankingDbContext>(options
                => options.UseNpgsql(configuration.GetConnectionString("BankingDbConnection")));
        }

        public static void ConfigureServices(this IServiceCollection services)
        {
            DependencyContainer.RegisterService(services);
        }
    }
}
