using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace AjayiTicket.TicketManagement.Application.Features.Events
{
    public class GetEventDetailQuery : IRequest<EventDetailDto>
    {
        public Guid Id { get; set; }
    }
}
