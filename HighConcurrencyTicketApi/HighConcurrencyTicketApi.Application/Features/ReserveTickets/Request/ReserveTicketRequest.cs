namespace HighConcurrencyTicketApi.Application.Features.ReserveTickets.Request
{
    public class ReserveTicketRequest
    {
        public Guid EventId { get; init; }
        public Guid UserId { get; init; }
    }
}
