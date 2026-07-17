using HighConcurrencyTicketApi.Application.Features.CreateEvent.Interfaces;
using HighConcurrencyTicketApi.Application.Features.CreateEvent.Request;
using HighConcurrencyTicketApi.Application.Features.GetEvent.Interfaces;
using HighConcurrencyTicketApi.Application.Features.ReserveTickets.Interfaces;
using HighConcurrencyTicketApi.Application.Features.ReserveTickets.Request;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace HighConcurrencyTicketApi.Api.Controllers
{
    [ApiController]
    [Route("api/events")]
    public class EventsController : ControllerBase
    {
        private readonly ICreateEventHandler _createEventHandler;
        private readonly IGetEventHandler _getEventHandler;
        private readonly IReserveTicketHandler _reserveTicketHandler;

        public EventsController(
            ICreateEventHandler createEventHandler,
            IGetEventHandler getEventHandler,
            IReserveTicketHandler reserveTicketHandler)
        {
            _createEventHandler = createEventHandler;
            _getEventHandler = getEventHandler;
            _reserveTicketHandler = reserveTicketHandler;
        }

        [HttpPost]
        public async Task<IActionResult> CreateEvent([FromBody] CreateEventRequest request)
        {
            var response = await _createEventHandler.CreateEvent(request);

            if (!response.Success)
            {
                return BadRequest(response.ErrorMessages);
            }

            return Created();
        }

        [HttpGet("{eventId:guid}")]
        public async Task<IActionResult> GetEvent([FromRoute][Required] Guid eventId)
        {
            var response = await _getEventHandler.GetEvent(eventId);

            if (!response.Success) 
            {
                return BadRequest(response.ErrorMessages);
            }

            return Ok(response);
        }

        [HttpPost("{eventId:guid}/reserve")]
        public async Task<IActionResult> ReserveTicket([FromRoute][Required] Guid eventId, [FromBody][Required] ReserveTicketRequest request)
        {
            var command = new ReserveTicketRequest
            {
                EventId = eventId,
                UserId = Guid.NewGuid() //only for tests
            };

            var response = await _reserveTicketHandler.ReserveTicket(command);

            if (!response.Success)
            {
                return BadRequest(response.ErrorMessages);
            }

            return Ok(response);
        }
    }
}
