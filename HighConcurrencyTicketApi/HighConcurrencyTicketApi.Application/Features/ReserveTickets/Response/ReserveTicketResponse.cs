namespace HighConcurrencyTicketApi.Application.Features.ReserveTickets.Response
{
    public class ReserveTicketResponse
    {
        public Guid ReservationId { get; init; }

        public Guid EventId { get; init; }

        public DateTime ReservedAt { get; init; }
    }
}
