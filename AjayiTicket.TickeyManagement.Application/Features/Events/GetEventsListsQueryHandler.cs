using AjayiTicket.TicketManagement.Application.Contracts.Persistence;
using AjayiTicket.TicketManagement.Domain.Entities;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AjayiTicket.TicketManagement.Application.Features.Events
{
    public class GetEventsListsQueryHandler : IRequestHandler<GetEventsListQuery, List<EventListDto>>
    {
        private readonly IAsyncRepository<Event> _eventRepository;
        private readonly IMapper _mapper;

        public GetEventsListsQueryHandler(IMapper mapper, IAsyncRepository<Event> eventRepository)
        {
            _mapper = mapper;
            _eventRepository = eventRepository;
        }
        public async Task<List<EventListDto>> Handle(GetEventsListQuery request, CancellationToken cancellationToken)
        {
            var allEvents = (await _eventRepository.ListAllAsync()).OrderBy(x => x.Date);
            return _mapper.Map<List<EventListDto>>(allEvents);
        }
    }
}
