﻿using GloboTicket.TicketManagement.Domain.Entities;

namespace GloboTicket.TicketManagement.Application.Contracts.Persistance;

public interface IEventRepository : IAsyncRepository<Event>
{
    
}