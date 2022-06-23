using System;
using System.Collections.Generic;
using SahinTurizim.Entity;

namespace SahinTurizim.WebUI.Models
{
    public class ExpeditionTickets
    {
        public List<Ticket> tickets { get; set; }
        public List<Expedition> Expeditions { get; set; }
        public List<City> cities { get; set; }
        public Expedition expedition { get; set; }
        public string time { get; set; }
        public string date { get; set; }
        public Ticket ticket { get; set; }

    }
}
