using HighConcurrencyTicketApi.Application.Features.ReserveTickets.Interfaces;
using HighConcurrencyTicketApi.Application.Features.ReserveTickets.Request;
using HighConcurrencyTicketApi.Application.Features.ReserveTickets.Response;
using HighConcurrencyTicketApi.Application.Interfaces.Repositories;
using HighConcurrencyTicketApi.Application.Shared;

namespace HighConcurrencyTicketApi.Application.Features.ReserveTickets
{
    public class ReserveTicketHandler : IReserveTicketHandler
    {
        private readonly IEventRepository _eventRepository;

        public ReserveTicketHandler(IEventRepository eventRepository)
        {
            _eventRepository = eventRepository;
        }
        public async Task<Output<ReserveTicketResponse>> ReserveTicket(ReserveTicketRequest request)
        {
            var result = new Output<ReserveTicketResponse>();
            try
            {
                var eventEntity = await _eventRepository.GetEventById(request.EventId);
                if (eventEntity == null)
                {
                    result.AddError("Event not found.");
                    return result;
                }

                eventEntity.ReserveTicket();

                await _eventRepository.UpdateEvent(eventEntity);

                result.Result = new ReserveTicketResponse
                {
                    EventId = eventEntity.Id,
                    AvailableTickets = eventEntity.AvailableTickets
                };
            }
            catch(Exception e)
            {
                result.AddError("An error occurred while reserving the ticket.");
            }
            return result;
        }
    }
}
