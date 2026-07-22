using HighConcurrencyTicketApi.Application.Features.CreateEvent.Interfaces;
using HighConcurrencyTicketApi.Application.Features.CreateEvent.Request;
using HighConcurrencyTicketApi.Application.Interfaces.Repositories;
using HighConcurrencyTicketApi.Application.Shared;
using HighConcurrencyTicketApi.Domain.Entities;

namespace HighConcurrencyTicketApi.Application.Features.CreateEvent
{
    public class CreateEventHandler : ICreateEventHandler
    {
        private readonly ICreateEventValidator _validator;
        private readonly IEventRepository _eventRepository;

        public CreateEventHandler(ICreateEventValidator validator, IEventRepository eventRepository)
        {
            _validator = validator;
            _eventRepository = eventRepository;
        }

        public async Task<Output<Guid>> CreateEvent(CreateEventRequest request)
        {
            var result = new Output<Guid>();
            try
            {

                var validation = _validator.Validate(request);
                if (!validation.Success)
                {
                    result.AddErrors(validation.ErrorMessages);
                    return result;
                }

                var eventEntity = new Event(request.Name,
                    request.Location,
                    request.StartsAt,
                    request.TotalTickets,
                    request.TicketPrice);

                await _eventRepository.AddEvent(eventEntity);

                result.Result = eventEntity.Id;
                return result;
            }
            catch (Exception e)
            {
                result.AddError("An error occurred while creating the event.");
                return result;
            }
        }
    }
}
