using HighConcurrencyTicketApi.Application.Features.ReserveTickets.Request;
using HighConcurrencyTicketApi.Application.Features.ReserveTickets.Response;
using HighConcurrencyTicketApi.Application.Shared;

namespace HighConcurrencyTicketApi.Application.Features.ReserveTickets.Interfaces
{
    public interface IReserveTicketHandler
    {
        Task<Output<ReserveTicketResponse>> ReserveTicket(ReserveTicketRequest request);
    }
}
