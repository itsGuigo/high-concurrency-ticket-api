using HighConcurrencyTicketApi.Application.Interfaces.Repositories;
using HighConcurrencyTicketApi.Infrastructure.Persistence;
using HighConcurrencyTicketApi.Infrastructure.Persistence.Repositores;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace HighConcurrencyTicketApi.Infrastructure.DepedencyInjection
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<TicketDbContext>(options =>
            {
                options.UseSqlite(
                    configuration.GetConnectionString("DefaultConnection"));
            });

            services.AddScoped<IEventRepository, EventRepository>();

            return services;
        }
    }
}
