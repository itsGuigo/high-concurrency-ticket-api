using HighConcurrencyTicketApi.Application.Features.ReserveTickets.Interfaces;
using HighConcurrencyTicketApi.Application.Features.ReserveTickets.Request;
using HighConcurrencyTicketApi.Application.Features.ReserveTickets.Response;
using HighConcurrencyTicketApi.Application.Shared;

namespace HighConcurrencyTicketApi.Application.Features.ReserveTickets
{
    public class ReserveTicketHandler : IReserveTicketHandler
    {
        public async Task<Output<ReserveTicketResponse>> ReserveTicket(ReserveTicketRequest request)
        {
            //TO DO: implement logic to reserve a ticket 
            throw new NotImplementedException();
        }
    }
}
