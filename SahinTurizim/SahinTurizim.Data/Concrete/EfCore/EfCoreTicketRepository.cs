using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using SahinTurizim.Data.Abstract;
using SahinTurizim.Entity;

namespace SahinTurizim.Data.Concrete.EfCore
{
    public class EfCoreTicketRepository : EfCoreGenericRepository<Ticket, SahinTurizimContext>, ITicketRepository
    {
        public List<int> GetSeat(int expeditionId)
        {
            using (var context = new SahinTurizimContext())
            {
                var seat = context.Tickets
                    .Where(i => i.ExpeditionId == expeditionId)
                    .Select(i => i.SeatNumber)
                    .ToList();

                return seat;
            }
        }
        public int GetSeatNumber(int expeditionid)
        {
            using (var context=new SahinTurizimContext())
            {
                return context.Tickets.Where(i => i.ExpeditionId == expeditionid).Select(i => i.SeatNumber).Count();
            }
        }

        public Ticket GetTicketByExpeditionId(int id)
        {
            using (var context=new SahinTurizimContext())
            {
                return context.Tickets.Where(i=>i.ExpeditionId==id).Include(i => i.Expedition).ThenInclude(i => i.Bus).FirstOrDefault();
            }
        }
        public int GetId()
        {
            using (var context = new SahinTurizimContext())
            {
                var id = context.Tickets
                    .OrderByDescending(i => i.TicketId)
                    .Select(i => i.ExpeditionId)
                    .FirstOrDefault();
                return id;
            }
        }

        public Ticket GetLastTicket()
        {

            using (var context=new SahinTurizimContext())
            {
                var lastTicket = context.Tickets.OrderByDescending(i => i.TicketId).FirstOrDefault();
                return lastTicket;
            }
        }

        public string GetDate(int expeditinId)
        {
            using (var context=new SahinTurizimContext())
            {
                var ticketDate = context.Expeditions.Where(i=>i.ExpeditionId==expeditinId).Select(i=>i.Date).FirstOrDefault();
                return ticketDate;
            }

        }

        public string GetHour(int expeditinId)
        {
            using (var context=new SahinTurizimContext())
            {
                var time = context.Expeditions.Where(i => i.ExpeditionId == expeditinId).Select(i => i.Hour).FirstOrDefault();
                return time;
            }
        }
    }
}
