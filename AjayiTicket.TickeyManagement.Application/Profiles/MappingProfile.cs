using AjayiTicket.TicketManagement.Application.Features.Events;
using AjayiTicket.TicketManagement.Domain.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace AjayiTicket.TicketManagement.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Event, EventListDto>().ReverseMap();
            CreateMap<Event, EventDetailDto>().ReverseMap();
            CreateMap<Category, CategoryDto>();
        }
    }
}
