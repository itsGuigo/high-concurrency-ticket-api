namespace HighConcurrencyTicketApi.Domain.Entities
{
    public class Event
    {
        public Guid Id { get; private set; }

        public string Name { get; private set; }

        public string Location { get; private set; }

        public DateTime StartsAt { get; private set; }

        public int TotalTickets { get; private set; }

        public int AvailableTickets { get; private set; }

        public decimal TicketPrice { get; private set; }

        private Event() { }

        public Event(
            string name,
            string location,
            DateTime startsAt,
            int totalTickets,
            decimal ticketPrice)
        {
            Id = Guid.NewGuid();

            Name = name;
            Location = location;
            StartsAt = startsAt;
            TotalTickets = totalTickets;
            AvailableTickets = totalTickets;
            TicketPrice = ticketPrice;
        }
    }
}
