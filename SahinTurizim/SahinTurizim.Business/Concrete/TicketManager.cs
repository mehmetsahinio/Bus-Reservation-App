using System;
using System.Collections.Generic;
using SahinTurizim.Business.Abstract;
using SahinTurizim.Data.Abstract;
using SahinTurizim.Entity;

namespace SahinTurizim.Business.Concrete
{
    public class TicketManager : ITicketService

    {
        private ITicketRepository _ticketRepository;

        public TicketManager(ITicketRepository ticketRepository)
        {
            _ticketRepository = ticketRepository;
        }

        public void Create(Ticket entiity)
        {

              _ticketRepository.Create(entiity);
        }

        public void Delete(Ticket entity)
        {
            _ticketRepository.Delete(entity);
        }

        public List<Ticket> GetAll()
        {
            return _ticketRepository.GetAll();
        }

        public Ticket GetById(int id)
        {
            return _ticketRepository.GetById(id);
        }

        public string GetDate(int expeditinId)
        {
            return _ticketRepository.GetDate(expeditinId);
        }

        public string GetHour(int expeditinId)
        {
            return _ticketRepository.GetHour(expeditinId);
        }

        public int GetId()
        {
            return _ticketRepository.GetId();
        }

        public Ticket GetLastTicket()
        {
            return _ticketRepository.GetLastTicket();
        }

        public List<int> GetSeat(int expeditionId)
        {
            return _ticketRepository.GetSeat(expeditionId);
        }

        public int GetSeatNumber(int id)
        {
            return _ticketRepository.GetSeatNumber(id);
        }

        public Ticket GetTicketByExpeditionId(int id)
        {
            return _ticketRepository.GetTicketByExpeditionId(id);
        }

        public string GetTime(int expeditinId)
        {
            return _ticketRepository.GetHour(expeditinId);
        }

        public void Update(Ticket entity)
        {
            _ticketRepository.Update(entity);
        }
    }
}
