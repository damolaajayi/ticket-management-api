using System;
using System.Collections.Generic;
using System.Text;

namespace AjayiTicket.TicketManagement.Application.Features.Events
{
    public class EventListDto
    {
        public Guid EventId { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string ImageUrl { get; set; }
    }
}
