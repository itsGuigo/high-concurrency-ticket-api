using HighConcurrencyTicketApi.Application.Features.CreateEvent.Request;
using HighConcurrencyTicketApi.Application.Shared;

namespace HighConcurrencyTicketApi.Application.Features.CreateEvent.Interfaces
{
    public interface ICreateEventValidator
    {
        Output Validate(CreateEventRequest request);
    }
}
