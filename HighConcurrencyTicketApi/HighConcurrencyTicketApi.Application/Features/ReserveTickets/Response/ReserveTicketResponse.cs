namespace HighConcurrencyTicketApi.Application.Features.ReserveTickets.Response
{
    public class ReserveTicketResponse
    {
        public Guid EventId { get; init; }

        public int AvailableTickets { get; init; }
    }
}
