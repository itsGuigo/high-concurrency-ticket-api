using HighConcurrencyTicketApi.Application.Interfaces.Repositories;
using HighConcurrencyTicketApi.Domain.Entities;

namespace HighConcurrencyTicketApi.Infrastructure.Persistence.Repositores
{
    public class EventRepository : IEventRepository
    {
        private readonly TicketDbContext _context;

        public EventRepository(TicketDbContext context)
        {
            _context = context;
        }

        public async Task AddEvent(Event entity)
        {
            await _context.Events.AddAsync(entity);

            await _context.SaveChangesAsync();
        }

        public async Task<Event?> GetEventById(Guid id)
        {
            return await _context.Events.FindAsync(id);
        }

        public async Task UpdateEvent(Event entity)
        {
            _context.Events.Update(entity);

            await _context.SaveChangesAsync();
        }
    }
}
