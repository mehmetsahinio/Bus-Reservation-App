using System;
using System.Collections.Generic;

namespace SahinTurizim.Entity
{
    public class Expedition
    {
        public int ExpeditionId { get; set; }
        public string StartTerminal { get; set; }
        public string FirstTerminal { get; set; }
        public string SecondTerminal { get; set; }
        public string ThirdTerminal { get; set; }
        public string EndTerminal { get; set; }
        public string Date { get; set; }
        public string Hour { get; set; }
        public double Price { get; set; }
        public string Url { get; set; }
        public List<City> Cities { get; set; }
        public Bus Bus { get; set; }
        public int BusId { get; set; }
        public List<Ticket> Tickets { get; set; }
    }
}
