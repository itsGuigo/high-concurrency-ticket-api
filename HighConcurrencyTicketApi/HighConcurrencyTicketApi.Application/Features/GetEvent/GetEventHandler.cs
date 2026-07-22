using HighConcurrencyTicketApi.Application.Features.GetEvent.Interfaces;
using HighConcurrencyTicketApi.Application.Features.GetEvent.Response;
using HighConcurrencyTicketApi.Application.Interfaces.Repositories;
using HighConcurrencyTicketApi.Application.Shared;

namespace HighConcurrencyTicketApi.Application.Features.GetEvent
{
    public class GetEventHandler : IGetEventHandler
    {
        private readonly IEventRepository _eventRepository;

        public GetEventHandler(IEventRepository eventRepository)
        {
            _eventRepository = eventRepository;
        }
        public async Task<Output<GetEventResponse>> GetEvent(Guid eventId)
        {
            var result = new Output<GetEventResponse>();

            try
            {
                var eventEntity = await _eventRepository.GetEventById(eventId);
                if (eventEntity == null)
                {
                    result.AddError("Event not found.");
                    return result;
                }

                result.Result = new GetEventResponse
                {
                    Name = eventEntity.Name,
                    Location = eventEntity.Location,
                    StartsAt = eventEntity.StartsAt,
                    TotalTickets = eventEntity.TotalTickets,
                    TicketPrice = eventEntity.TicketPrice
                };
            }
            catch (Exception e)
            {
                result.AddError("An error occurred while fetching the event.");
            }

            return result;
        }
    }
}
