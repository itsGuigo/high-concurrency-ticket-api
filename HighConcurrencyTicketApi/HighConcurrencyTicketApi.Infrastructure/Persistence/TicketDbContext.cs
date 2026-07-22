using HighConcurrencyTicketApi.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace HighConcurrencyTicketApi.Infrastructure.Persistence
{
    public class TicketDbContext : DbContext
    {
        public TicketDbContext(DbContextOptions<TicketDbContext> options) : base(options)
        {
        }

        public DbSet<Event> Events => Set<Event>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(TicketDbContext).Assembly);

            base.OnModelCreating(modelBuilder);
        }
    }
}
