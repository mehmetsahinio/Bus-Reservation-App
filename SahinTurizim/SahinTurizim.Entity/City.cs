using System.Collections.Generic;

namespace SahinTurizim.Entity
{
    public class City
    {
        public int CityId { get; set; }
        public string CityNumber { get; set; }
        public string CityName { get; set; }
        public string CityAbout { get; set; }
        public string Url { get; set; }
        public string ImgUrl { get; set; }
        public List<Expedition> Expedition { get; set; }

    }
}
