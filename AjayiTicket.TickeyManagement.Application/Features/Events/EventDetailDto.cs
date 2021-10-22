﻿using AjayiTicket.TicketManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AjayiTicket.TicketManagement.Application.Features.Events
{
    public class EventDetailDto
    {
        public Guid EventId { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Artist { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public Guid CategoryId { get; set; }
        public CategoryDto Category { get; set; }
    }
}
