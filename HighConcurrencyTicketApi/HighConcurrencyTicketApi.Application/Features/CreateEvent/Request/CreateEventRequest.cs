namespace HighConcurrencyTicketApi.Application.Features.CreateEvent.Request
{
    public class CreateEventRequest
    {
        public string Name { get; set; } = string.Empty;

        public int TotalTickets { get; set; }

        public DateTime StartsAt { get; set; }

        public string Location { get; set; } = string.Empty;

        public decimal TicketPrice { get; set; }
    }
}
