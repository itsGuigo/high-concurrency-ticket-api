using HighConcurrencyTicketApi.Application.Features.CreateEvent.Request;
using HighConcurrencyTicketApi.Application.Shared;

namespace HighConcurrencyTicketApi.Application.Features.CreateEvent.Interfaces
{
    public interface ICreateEventHandler
    {
        Task<Output<Guid>> CreateEvent(CreateEventRequest request);
    }
}
