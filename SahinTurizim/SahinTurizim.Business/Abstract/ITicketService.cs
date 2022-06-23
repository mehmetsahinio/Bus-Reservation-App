using System;
using System.Collections.Generic;
using SahinTurizim.Entity;

namespace SahinTurizim.Business.Abstract
{
    public interface ITicketService/*:IRepository<Ticket> Böylede CRUD işlemlerini hallede bilirdim*/
    {
        Ticket GetById(int id);
        List<Ticket> GetAll();
        void Create(Ticket entity);
        void Update(Ticket entity);
        void Delete(Ticket entity);

        Ticket GetTicketByExpeditionId(int id);
        int GetSeatNumber(int expeditionId);
        List<int> GetSeat(int expeditionId);
        Ticket GetLastTicket();
        string GetHour(int expeditinId);
        string GetDate(int expeditinId);
        int GetId();
    }
}
