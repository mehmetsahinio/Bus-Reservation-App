using System;
using System.Collections.Generic;
using SahinTurizim.Entity;

namespace SahinTurizim.Data.Abstract
{
    public interface ITicketRepository:IRepository<Ticket>
    {
        Ticket GetTicketByExpeditionId(int id);
        int GetSeatNumber(int id);
        List<int> GetSeat(int expeditionId);
        Ticket GetLastTicket();
        string GetDate(int expeditinId);
        int GetId();
        string GetHour(int expeditinId);
    }
}
