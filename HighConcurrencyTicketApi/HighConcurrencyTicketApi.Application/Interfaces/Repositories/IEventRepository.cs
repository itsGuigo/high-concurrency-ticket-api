using EventDomain = HighConcurrencyTicketApi.Domain.Entities;

namespace HighConcurrencyTicketApi.Application.Interfaces.Repositories
{
    public interface IEventRepository
    {
        Task AddEvent(EventDomain.Event entity);

        Task<EventDomain.Event?> GetEventById(Guid id);

        Task UpdateEvent(EventDomain.Event entity);
    }
}
