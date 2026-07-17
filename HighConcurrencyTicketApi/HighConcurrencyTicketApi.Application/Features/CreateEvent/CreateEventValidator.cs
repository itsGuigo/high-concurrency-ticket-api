using HighConcurrencyTicketApi.Application.Features.CreateEvent.Interfaces;
using HighConcurrencyTicketApi.Application.Features.CreateEvent.Request;
using HighConcurrencyTicketApi.Application.Shared;

namespace HighConcurrencyTicketApi.Application.Features.CreateEvent
{
    public class CreateEventValidator : ICreateEventValidator
    {
        public Output Validate(CreateEventRequest request)
        {
            var output = new Output();

            if (string.IsNullOrWhiteSpace(request.Name))
                output.AddError("Event name is required.");

            if (request.TotalTickets <= 0)
                output.AddError("Total tickets must be greater than zero.");

            if (request.TicketPrice <= 0)
                output.AddError("Ticket price must be greater than zero.");

            if (request.StartsAt <= DateTime.UtcNow)
                output.AddError("Event date must be in the future.");

            if (string.IsNullOrWhiteSpace(request.Location))
                output.AddError("Location is required.");

            return output;
        }
    }
}
