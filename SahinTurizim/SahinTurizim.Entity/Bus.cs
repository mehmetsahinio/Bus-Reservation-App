using System;
using System.Collections.Generic;

namespace SahinTurizim.Entity
{
    public class Bus
    {
        public int BusId { get; set; }
        public string BusPlaque { get; set; }
        public int SeatCapasite { get; set; }
        public string Url { get; set; }
        public List<Expedition> Expeditions { get; set; }

    }
}
