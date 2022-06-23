using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using SahinTurizim.Entity;

namespace SahinTurizim.Data.Concrete.EfCore
{
    public class SeeadDatabase
    {
        public static void Seed()
        {
            var context = new SahinTurizimContext();
            if (context.Database.GetPendingMigrations().Count()==0)
            {

                if (context.Buses.Count() == 0)
                {
                    context.Buses.AddRange(Buses);
                }
                if (context.Cities.Count() == 0)
                {
                    context.Cities.AddRange(Cities);
                }
                if (context.Expeditions.Count() == 0)
                {
                    context.Expeditions.AddRange(Expeditions);
                }
                if (context.Tickets.Count() == 0)
                {
                    context.Tickets.AddRange(Tickets);
                }
                context.SaveChanges();
            }
        }
        private static Bus[] Buses =
        {
            new Bus(){BusId=1, BusPlaque="02 ATM 1435",SeatCapasite=40,Url="Bus"},
            new Bus(){BusId=2,  BusPlaque="01 AD 2235",SeatCapasite=40,Url="Bus"},
            new Bus(){BusId=3,  BusPlaque="35 MSK 1881",SeatCapasite=40,Url="Bus"},
            new Bus(){BusId=4,  BusPlaque="06 ANT 1938",SeatCapasite=40,Url="Bus"},
            new Bus(){BusId=5,  BusPlaque="81 DNZ 1995",SeatCapasite=40,Url="Bus"},
            new Bus(){BusId=6,  BusPlaque="23 DYB 2323",SeatCapasite=40,Url="Bus"},
            new Bus(){BusId=7,  BusPlaque="25 ERZ 2534",SeatCapasite=40,Url="Bus"},
            new Bus(){BusId=8,  BusPlaque="45 KRM 5983",SeatCapasite=40,Url="Bus"},
            new Bus(){BusId=9,  BusPlaque="67 KLM 4978",SeatCapasite=40,Url="Bus"},
            new Bus(){BusId=10,  BusPlaque="74 FG 6789",SeatCapasite=40,Url="Bus"},
            new Bus(){BusId=11,  BusPlaque="56 Er 3241",SeatCapasite=40,Url="Bus"},
            new Bus(){BusId=12,  BusPlaque="12 HA 9866",SeatCapasite=40,Url="Bus"},
        };

        private static City[] Cities =
        {
            new City(){CityId=1,CityNumber="01",CityName="ADANA",CityAbout="Sonra Düzeltilecek",Url="City",ImgUrl="1.png"},
            new City(){CityId=2, CityNumber="02",CityName="ADIYAMAN",CityAbout="Sonra Düzeltilecek",Url="City",ImgUrl="2.png"},
            new City(){CityId=3,CityNumber="03",CityName="AFYONKARAHİSAR",CityAbout="Sonra Düzeltilecek",Url="City",ImgUrl="3.png"},
            new City(){CityId=4,CityNumber="04",CityName="AĞRI",CityAbout="Sonra Düzeltilecek",Url="City",ImgUrl="4.png"},
            new City(){CityId=5,CityNumber="05",CityName="AMASYA",CityAbout="Sonra Düzeltilecek",Url="City",ImgUrl="5.png"},
            new City(){CityId=6,CityNumber="06",CityName="ANKARA",CityAbout="Sonra Düzeltilecek",Url="City",ImgUrl="6.png"},
            new City(){CityId=7,CityNumber="07",CityName="ANTALYA",CityAbout="Sonra Düzeltilecek",Url="City",ImgUrl="7.png"},
            new City(){CityId=8,CityNumber="08",CityName="ARTVİN",CityAbout="Sonra Düzeltilecek",Url="City",ImgUrl="8.png"},
            new City(){CityId=9,CityNumber="09",CityName="AYDIN",CityAbout="Sonra Düzeltilecek",Url="City",ImgUrl="9.png"},
            new City(){CityId=10,CityNumber="10",CityName="BALIKESİR",CityAbout="Sonra Düzeltilecek",Url="City",ImgUrl="10.png"},
            new City(){CityId=11,CityNumber="11",CityName="BİLECİK",CityAbout="Sonra Düzeltilecek",Url="City",ImgUrl="11.png"},
            new City(){CityId=12,CityNumber="12",CityName="BİNGÖL",CityAbout="Sonra Düzeltilecek",Url="City",ImgUrl="12.png"},
            new City(){CityId=13,CityNumber="13",CityName="BİTLİS",CityAbout="Sonra Düzeltilecek",Url="City",ImgUrl="13.png"},
            new City(){CityId=14,CityNumber="14",CityName="BOLU",CityAbout="Sonra Düzeltilecek",Url="City",ImgUrl="1.png"},
            new City(){CityId=15,CityNumber="15",CityName="BURDUR",CityAbout="Sonra Düzeltilecek",Url="City",ImgUrl="1.png"},
            new City(){CityId=16,CityNumber="16",CityName="BURSA",CityAbout="Sonra Düzeltilecek",Url="City",ImgUrl="1.png"},
            new City(){CityId=17,CityNumber="17",CityName="ÇANAKKALE",CityAbout="Sonra Düzeltilecek",Url="City",ImgUrl="1.png"},
            new City(){CityId=18,CityNumber="18",CityName="ÇANKIRI",CityAbout="Sonra Düzeltilecek",Url="City",ImgUrl="1.png"},
            new City(){CityId=19,CityNumber="19",CityName="ÇORUM",CityAbout="Sonra Düzeltilecek",Url="City",ImgUrl="1.png"},
            new City(){CityId=20,CityNumber="20",CityName="DENİZLİ",CityAbout="Sonra Düzeltilecek",Url="City",ImgUrl="1.png"},
            new City(){CityId=21,CityNumber="21",CityName="DİYARBAKIR",CityAbout="Sonra Düzeltilecek",Url="City",ImgUrl="1.png"},
            new City(){CityId=22,CityNumber="22",CityName="EDİRNE",CityAbout="Sonra Düzeltilecek",Url="City",ImgUrl="1.png"},
            new City(){CityId=23,CityNumber="23",CityName="ELAZIĞ",CityAbout="Sonra Düzeltilecek",Url="City",ImgUrl="1.png"},
            new City(){CityId=24,CityNumber="24",CityName="ERZİNCAN",CityAbout="Sonra Düzeltilecek",Url="City",ImgUrl="1.png"},
            new City(){CityId=25,CityNumber="25",CityName="ERZURUM",CityAbout="Sonra Düzeltilecek",Url="City",ImgUrl="1.png"},
            new City(){CityId=26,CityNumber="26",CityName="ESKİŞEHİR",CityAbout="Sonra Düzeltilecek",Url="City",ImgUrl="1.png"},
            new City(){CityId=27,CityNumber="27",CityName="GAZİANTEP",CityAbout="Sonra Düzeltilecek",Url="City",ImgUrl="1.png"},
            new City(){CityId=28,CityNumber="28",CityName="GİRESUN",CityAbout="Sonra Düzeltilecek",Url="City",ImgUrl="1.png"},
            new City(){CityId=29,CityNumber="29",CityName="GÜMÜŞHANE",CityAbout="Sonra Düzeltilecek",Url="City",ImgUrl="1.png"},
            new City(){CityId=30,CityNumber="30",CityName="HAKKARİ",CityAbout="Sonra Düzeltilecek",Url="City",ImgUrl="1.png"},
            new City(){CityId=31,CityNumber="31",CityName="HATAY",CityAbout="Sonra Düzeltilecek",Url="City",ImgUrl="1.png"},
            new City(){CityId=32,CityNumber="32",CityName="ISPARTA",CityAbout="Sonra Düzeltilecek",Url="City",ImgUrl="1.png"},
            new City(){CityId=33,CityNumber="33",CityName="MERSİN",CityAbout="Sonra Düzeltilecek",Url="City",ImgUrl="1.png"},
            new City(){CityId=34,CityNumber="34",CityName="İSTANBUL",CityAbout="Sonra Düzeltilecek",Url="City",ImgUrl="1.png"},
            new City(){CityId=35,CityNumber="35",CityName="İZMİR",CityAbout="Sonra Düzeltilecek",Url="City",ImgUrl="1.png"},
            new City(){CityId=36,CityNumber="36",CityName="KARS",CityAbout="Sonra Düzeltilecek",Url="City",ImgUrl="1.png"},
            new City(){CityId=37,CityNumber="37",CityName="KASTAMONU",CityAbout="Sonra Düzeltilecek",Url="City",ImgUrl="1.png"},
            new City(){CityId=38,CityNumber="38",CityName="KAYSERİ",CityAbout="Sonra Düzeltilecek",Url="City",ImgUrl="1.png"},
            new City(){CityId=39,CityNumber="39",CityName="KIRKLARELİ",CityAbout="Sonra Düzeltilecek",Url="City",ImgUrl="1.png"},
            new City(){CityId=40,CityNumber="40",CityName="KIRŞEHİR",CityAbout="Sonra Düzeltilecek",Url="City",ImgUrl="1.png"},
            new City(){CityId=41,CityNumber="41",CityName="KOCAELİ",CityAbout="Sonra Düzeltilecek",Url="City",ImgUrl="1.png"},
            new City(){CityId=42,CityNumber="42",CityName="KONYA",CityAbout="Sonra Düzeltilecek",Url="City",ImgUrl="1.png"},
            new City(){CityId=43,CityNumber="43",CityName="KÜTAHYA",CityAbout="Sonra Düzeltilecek",Url="City",ImgUrl="1.png"},
            new City(){CityId=44,CityNumber="44",CityName="MALATYA",CityAbout="Sonra Düzeltilecek",Url="City",ImgUrl="1.png"},
            new City(){CityId=45,CityNumber="45",CityName="MANİSA",CityAbout="Sonra Düzeltilecek",Url="City",ImgUrl="1.png"},
            new City(){CityId=46,CityNumber="46",CityName="KAHRAMANMARAŞ",CityAbout="Sonra Düzeltilecek",Url="City",ImgUrl="1.png"},
            new City(){CityId=47,CityNumber="47",CityName="MARDİN",CityAbout="Sonra Düzeltilecek",Url="City",ImgUrl="1.png"},
            new City(){CityId=48,CityNumber="48",CityName="MUĞLA",CityAbout="Sonra Düzeltilecek",Url="City",ImgUrl="1.png"},
            new City(){CityId=49,CityNumber="49",CityName="MUŞ",CityAbout="Sonra Düzeltilecek",Url="City",ImgUrl="1.png"},
            new City(){CityId=50,CityNumber="50",CityName="NEVŞEHİR",CityAbout="Sonra Düzeltilecek",Url="City",ImgUrl="1.png"},
            new City(){CityId=51,CityNumber="51",CityName="NİĞDE",CityAbout="Sonra Düzeltilecek",Url="City",ImgUrl="1.png"},
            new City(){CityId=52,CityNumber="52",CityName="ORDU",CityAbout="Sonra Düzeltilecek",Url="City",ImgUrl="1.png"},
            new City(){CityId=53,CityNumber="53",CityName="RİZE",CityAbout="Sonra Düzeltilecek",Url="City",ImgUrl="1.png"},
            new City(){CityId=54,CityNumber="54",CityName="SAKARYA",CityAbout="Sonra Düzeltilecek",Url="City",ImgUrl="1.png"},
            new City(){CityId=55,CityNumber="55",CityName="SAMSUNG",CityAbout="Sonra Düzeltilecek",Url="City",ImgUrl="1.png"},
            new City(){CityId=56,CityNumber="56",CityName="SİİRT",CityAbout="Sonra Düzeltilecek",Url="City",ImgUrl="1.png"},
            new City(){CityId=57,CityNumber="57",CityName="SİNOP",CityAbout="Sonra Düzeltilecek",Url="City",ImgUrl="1.png"},
            new City(){CityId=58,CityNumber="58",CityName="SİVAS",CityAbout="Sonra Düzeltilecek",Url="City",ImgUrl="1.png"},
            new City(){CityId=59,CityNumber="59",CityName="TEKİRDAĞ",CityAbout="Sonra Düzeltilecek",Url="City",ImgUrl="1.png"},
            new City(){CityId=60,CityNumber="60",CityName="TOKAT",CityAbout="Sonra Düzeltilecek",Url="City",ImgUrl="1.png"},
            new City(){CityId=61,CityNumber="61",CityName="TRABZON",CityAbout="Sonra Düzeltilecek",Url="City",ImgUrl="1.png"},
            new City(){CityId=62,CityNumber="62",CityName="TUNCELİ",CityAbout="Sonra Düzeltilecek",Url="City",ImgUrl="1.png"},
            new City(){CityId=63,CityNumber="63",CityName="ŞANLIURFA",CityAbout="Sonra Düzeltilecek",Url="City",ImgUrl="1.png"},
            new City(){CityId=64,CityNumber="64",CityName="UŞAK",CityAbout="Sonra Düzeltilecek",Url="City",ImgUrl="1.png"},
            new City(){CityId=65,CityNumber="65",CityName="VAN",CityAbout="Sonra Düzeltilecek",Url="City",ImgUrl="1.png"},
            new City(){CityId=66,CityNumber="66",CityName="YOZGAT",CityAbout="Sonra Düzeltilecek",Url="City",ImgUrl="1.png"},
            new City(){CityId=67,CityNumber="67",CityName="ZONGULDAK",CityAbout="Sonra Düzeltilecek",Url="City",ImgUrl="1.png"},
            new City(){CityId=68,CityNumber="68",CityName="AKSARAY",CityAbout="Sonra Düzeltilecek",Url="City",ImgUrl="1.png"},
            new City(){CityId=69,CityNumber="69",CityName="BAYBURT",CityAbout="Sonra Düzeltilecek",Url="City",ImgUrl="1.png"},
            new City(){CityId=70,CityNumber="70",CityName="KARAMAN",CityAbout="Sonra Düzeltilecek",Url="City",ImgUrl="1.png"},
            new City(){CityId=71,CityNumber="71",CityName="KIRIKKALE",CityAbout="Sonra Düzeltilecek",Url="City",ImgUrl="1.png"},
            new City(){CityId=72,CityNumber="72",CityName="BATMAN",CityAbout="Sonra Düzeltilecek",Url="City",ImgUrl="1.png"},
            new City(){CityId=73,CityNumber="73",CityName="ŞIRNAK",CityAbout="Sonra Düzeltilecek",Url="City",ImgUrl="1.png"},
            new City(){CityId=74,CityNumber="74",CityName="BARTIN",CityAbout="Sonra Düzeltilecek",Url="City",ImgUrl="1.png"},
            new City(){CityId=75,CityNumber="75",CityName="ARDAHAN",CityAbout="Sonra Düzeltilecek",Url="City",ImgUrl="1.png"},
            new City(){CityId=76,CityNumber="76",CityName="IĞDIR",CityAbout="Sonra Düzeltilecek",Url="City",ImgUrl="1.png"},
            new City(){CityId=77,CityNumber="77",CityName="YALOVA",CityAbout="Sonra Düzeltilecek",Url="City",ImgUrl="1.png"},
            new City(){CityId=78,CityNumber="78",CityName="KARABÜK",CityAbout="Sonra Düzeltilecek",Url="City",ImgUrl="1.png"},
            new City(){CityId=79,CityNumber="79",CityName="KİLİS",CityAbout="Sonra Düzeltilecek",Url="City",ImgUrl="1.png"},
            new City(){CityId=80,CityNumber="80",CityName="OSMANİYE",CityAbout="Sonra Düzeltilecek",Url="City",ImgUrl="1.png"},
            new City(){CityId=81,CityNumber="81",CityName="DÜZCE",CityAbout="Sonra Düzeltilecek",Url="City",ImgUrl="1.png"},

        };
        private static Expedition[] Expeditions =
        {
            new Expedition(){ExpeditionId=1, StartTerminal="İSTANBUL",FirstTerminal="ANKARA",SecondTerminal="KAYSERİ",ThirdTerminal="SİVAS",EndTerminal="ADANA",Date="2022-06-27",Hour="08:00",Price=500,Url="Expeditions",BusId=1},
            new Expedition(){ExpeditionId=2,StartTerminal="BURSA",FirstTerminal="ESKİŞEHİR",SecondTerminal="ISPARTA",ThirdTerminal="ANTALYA",EndTerminal="DENİZLİ",Date="2022-06-28",Hour="08:00",Price=500,Url="Expeditions",BusId=2},
            new Expedition(){ExpeditionId=3,StartTerminal="BALIKESİR",FirstTerminal="İZMİR",SecondTerminal="AYDIN",ThirdTerminal="KONYA",EndTerminal="MERSİN",Date="2022-06-29",Hour="08:00",Price=500,Url="Expeditions",BusId=3},
            new Expedition(){ExpeditionId=4,StartTerminal="BOLU",FirstTerminal="KARABÜK",SecondTerminal="ZONGULDAK",ThirdTerminal="DÜZCE",EndTerminal="SAKARYA",Date="2022-06-30",Hour="08:00",Price=500,Url="Expeditions",BusId=4},
            new Expedition(){ExpeditionId=5,StartTerminal="KIRIKKALE",FirstTerminal="YOZGAT",SecondTerminal="ADIYAMAN",ThirdTerminal="DİYARBAKIR",EndTerminal="MARDİN",Date="2022-07-01",Hour="08:00",Price=500,Url="Expeditions",BusId=5},
            new Expedition(){ExpeditionId=6,StartTerminal="ERZİNCAN",FirstTerminal="ERZURUM",SecondTerminal="BAYBURT",ThirdTerminal="RİZE",EndTerminal="TRABZON",Date="2022-07-10",Hour="08:00",Price=500,Url="Expeditions",BusId=6},
            new Expedition(){ExpeditionId=7,StartTerminal="ÇORUM",FirstTerminal="ORDU",SecondTerminal="TRABZON",ThirdTerminal="RİZE",EndTerminal="KARS",Date="2022-07-16",Hour="08:00",Price=500,Url="Expeditions",BusId=7},
            new Expedition(){ExpeditionId=8,StartTerminal="İSTANBUL",FirstTerminal="ANKARA",SecondTerminal="KONYA",ThirdTerminal="ANTALYA",EndTerminal="DENİZLİ",Date="2022-07-20",Hour="08:00",Price=500,Url="Expeditions",BusId=8},
            new Expedition(){ExpeditionId=9,StartTerminal="İSTANBUL",FirstTerminal="ANKARA",SecondTerminal="KAYSERİ",ThirdTerminal="TOKAT",EndTerminal="TRABZON",Date="2022-07-27",Hour="09:00",Price=500,Url="Expeditions",BusId=9},
            new Expedition(){ExpeditionId=10,StartTerminal="İSTANBUL",FirstTerminal="ANKARA",SecondTerminal="KAYSERİ",ThirdTerminal="SİVAS",EndTerminal="TRABZON",Date="2022-07-27",Hour="21:00",Price=500,Url="Expeditions",BusId=10},
            new Expedition(){ExpeditionId=11,StartTerminal="İSTANBUL",FirstTerminal="ANKARA",SecondTerminal="ZONGULDAK",ThirdTerminal="KARABÜK",EndTerminal="ORDU",Date="2022-07-30",Hour="13:00",Price=500,Url="Expeditions",BusId=11},
            new Expedition(){ExpeditionId=12,StartTerminal="İSTANBUL",FirstTerminal="SAKARYA",SecondTerminal="ZONGULDAK",ThirdTerminal="DÜZCE",EndTerminal="ORDU",Date="2022-07-30",Hour="20:00",Price=500,Url="Expeditions",BusId=12},
        };
        private static Ticket[] Tickets =
          {
            new Ticket(){TicketId=1, CustomerName="Mehmet",CustomerSurname="Şahin",CustomerPhone="+905455547677",CustomerTravel="İSTANBUL",CustomerToTravel="ADANA",SeatNumber=1,Price=500,PeronNumber=5554754,Url="Tickets",ExpeditionId=1},
            new Ticket(){TicketId=2,CustomerName="Mehmet",CustomerSurname="Şahin",CustomerPhone="+905455547677",CustomerTravel="BURSA",CustomerToTravel="DENİZLİ",SeatNumber=7,Price=500,PeronNumber=5554754,Url="Tickets",ExpeditionId=2},
            new Ticket(){TicketId=3,CustomerName="Mehmet",CustomerSurname="Şahin",CustomerPhone="+905455547677",CustomerTravel="BALIKESİR",CustomerToTravel="KONYA",SeatNumber=5,Price=300,PeronNumber=5554754,Url="Tickets",ExpeditionId=3},
            new Ticket(){TicketId=4,CustomerName="Mehmet",CustomerSurname="Şahin",CustomerPhone="+905455547677",CustomerTravel="BALIKESİR",CustomerToTravel="MERSİN",SeatNumber=11,Price=500,PeronNumber=5554754,Url="Tickets",ExpeditionId=3,}
        };
    }
}
