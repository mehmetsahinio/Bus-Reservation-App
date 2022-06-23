using System;
using System.Collections.Generic;
using SahinTurizim.Entity;

namespace SahinTurizim.WebUI.Models
{
    public class ListCityİnfo
    {
        public List<City> Cities { get; set; }
        public string startCity { get; set; }
        public string finishCity { get; set; }
        public string Date { get; set; }
        
    }
}
