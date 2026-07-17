using HighConcurrencyTicketApi.Application.Features.GetEvent.Response;
using HighConcurrencyTicketApi.Application.Shared;

namespace HighConcurrencyTicketApi.Application.Features.GetEvent.Interfaces
{
    public interface IGetEventHandler
    {
        Task<Output<GetEventResponse>> GetEvent(Guid eventId);
    }
}
