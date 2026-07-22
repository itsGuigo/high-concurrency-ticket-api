using HighConcurrencyTicketApi.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HighConcurrencyTicketApi.Infrastructure.Persistence.Configurations
{
    public class EventConfiguration : IEntityTypeConfiguration<Event>
    {
        public void Configure(EntityTypeBuilder<Event> builder)
        {
            builder.ToTable("Events");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .ValueGeneratedNever();

            builder.Property(x => x.Name)
                .HasMaxLength(200)
                .IsRequired();

            builder.Property(x => x.Location)
                .HasMaxLength(200)
                .IsRequired();

            builder.Property(x => x.StartsAt)
                .HasColumnType("datetime")
                .IsRequired();

            builder.Property(x => x.TotalTickets)
                .IsRequired();

            builder.Property(x => x.AvailableTickets)
                .IsRequired();

            builder.Property(x => x.TicketPrice)
                .HasPrecision(18, 2)
                .IsRequired();
        }
    }
}
