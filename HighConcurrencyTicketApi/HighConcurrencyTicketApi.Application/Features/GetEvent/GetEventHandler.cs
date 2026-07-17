using HighConcurrencyTicketApi.Application.Features.GetEvent.Interfaces;
using HighConcurrencyTicketApi.Application.Features.GetEvent.Response;
using HighConcurrencyTicketApi.Application.Shared;

namespace HighConcurrencyTicketApi.Application.Features.GetEvent
{
    public class GetEventHandler : IGetEventHandler
    {
        public async Task<Output<GetEventResponse>> GetEvent(Guid eventId)
        {
            //To do: implement logic
            throw new NotImplementedException();
        }
    }
}
