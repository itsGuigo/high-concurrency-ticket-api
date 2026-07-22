using HighConcurrencyTicketApi.Application.Features.CreateEvent;
using HighConcurrencyTicketApi.Application.Features.CreateEvent.Interfaces;
using HighConcurrencyTicketApi.Application.Features.GetEvent;
using HighConcurrencyTicketApi.Application.Features.GetEvent.Interfaces;
using HighConcurrencyTicketApi.Application.Features.ReserveTickets;
using HighConcurrencyTicketApi.Application.Features.ReserveTickets.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace HighConcurrencyTicketApi.Application.DependencyInjection
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddScoped<ICreateEventHandler, CreateEventHandler>();
            services.AddScoped<ICreateEventValidator, CreateEventValidator>();

            services.AddScoped<IGetEventHandler, GetEventHandler>();

            services.AddScoped<IReserveTicketHandler, ReserveTicketHandler>();

            return services;
        }
    }
}
