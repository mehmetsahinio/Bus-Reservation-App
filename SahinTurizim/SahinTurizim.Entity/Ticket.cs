using System;
namespace SahinTurizim.Entity
{
    public class Ticket
    {
        public int TicketId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
        public string CustomerPhone { get; set; }
        public string CustomerTravel { get; set; }
        public string CustomerToTravel { get; set; }
        public int SeatNumber { get; set; }
        public double Price { get; set; }
        public int PeronNumber { get; set; }
        public string Url { get; set; }
        public Expedition Expedition { get; set; }
        public int ExpeditionId { get; set; }

    }
}
