using System;
using System.Collections.Generic;
using SahinTurizim.Entity;

namespace SahinTurizim.WebUI.Models
{
    public class ListCityInfoTicket
    {
       

        public Expedition expedition { get; set; }
        public Ticket Ticket { get; set; }
        public List<City> Cities { get; set; }
        public List<Expedition> Expeditions { get; set; }
        public List<Ticket> Tickets { get; set; }
    }
}
