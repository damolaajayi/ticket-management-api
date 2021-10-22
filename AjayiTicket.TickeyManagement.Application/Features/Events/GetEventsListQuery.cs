using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace AjayiTicket.TicketManagement.Application.Features.Events
{
    public class GetEventsListQuery : IRequest<List<EventListDto>>
    {
    }
}
