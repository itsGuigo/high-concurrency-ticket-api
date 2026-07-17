using HighConcurrencyTicketApi.Application.Features.CreateEvent.Interfaces;
using HighConcurrencyTicketApi.Application.Features.CreateEvent.Request;
using HighConcurrencyTicketApi.Application.Shared;

namespace HighConcurrencyTicketApi.Application.Features.CreateEvent
{
    public class CreateEventHandler : ICreateEventHandler
    {
        private readonly ICreateEventValidator _validator;
        public CreateEventHandler(ICreateEventValidator validator)
        {
            _validator = validator;
        }
        public async Task<Output<Guid>> CreateEvent(CreateEventRequest request)
        {
            var result = new Output<Guid>();

            var validation = _validator.Validate(request);
            if (!validation.Success)
            {
                result.AddErrors(validation.ErrorMessages);
                return result;
            }

            result.Result = Guid.NewGuid();
            return result;
        }
    }
}
