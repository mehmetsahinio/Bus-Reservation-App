using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using SahinTurizim.Business.Abstract;
using SahinTurizim.Entity;
using SahinTurizim.WebUI.Models;

namespace SahinTurizim.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private ICityService _cityService;
        private IExpeditionService _expeditionService;
        private ITicketService _ticketService;
        private IBusService _busService;

        public HomeController(ICityService cityService, IExpeditionService expeditionService, ITicketService ticketService, IBusService busService)
        {
            _cityService = cityService;
            _expeditionService = expeditionService;
            _ticketService = ticketService;
            _busService = busService;
        }

        public IActionResult Index()
        {
            ViewBag.Cities = new SelectList(_cityService.GetAll(), "CityName", "CityName");
            ListCityİnfo listCityİnfo = new ListCityİnfo()
            {
                Cities = _cityService.GetAll(),

            };
            return View(listCityİnfo);
        }

        public IActionResult ExpeditionList(ListCityİnfo listCityİnfo)
        {
            ListCityInfoTicket listCityInfoTicket = new ListCityInfoTicket()
            {
                Expeditions = _expeditionService.GetExpeditionRoute(listCityİnfo.startCity, listCityİnfo.finishCity, listCityİnfo.Date)

            };
            return View(listCityInfoTicket);
        }

      /*  public IActionResult TicketSale(int id)
        {

            Expedition expedition = _expeditionService.GetExpeditionDetails(id);
            int seatNumber = _ticketService.GetSeatNumber(id);
            List<int> takenSeat = _ticketService.GetSeat(id);
            List<int> seatNumbers = new List<int>();
            int seats = _busService.GetSeatCapacity(id / id);

            for (int i = 1; i <= seats; i++)
            {
                seatNumbers.Add(i);
            }

            foreach (var item in takenSeat)
            {
                seatNumbers.Remove(item);
            }

            ViewBag.Seat = seats;
            ViewBag.SeatNumber = seatNumber;
            ViewBag.SeatNumbers = new SelectList(seatNumbers);

            return View(expedition);
        }

        [HttpPost]
        public IActionResult TicketSale(int expeditionId, double price, string startLocation, string endLocation, int seatNumber, string phoneNumber, string firstName, string lastName)
        {
            Random rnd = new Random();
            int PrnNumber = rnd.Next();
            var entity = new Ticket()
            {
                CustomerName = firstName,
                CustomerSurname = lastName,
                CustomerPhone = phoneNumber,
                CustomerTravel = startLocation,
                CustomerToTravel = endLocation,
                SeatNumber = seatNumber,
                Price = price,
                ExpeditionId = expeditionId,
                PeronNumber = PrnNumber
            };
            _ticketService.Create(entity);
            return RedirectToAction("TicketSalesTicket");
        }
        public IActionResult TicketSalesTicket()
        {

            Ticket lastTicket = _ticketService.GetLastTicket();
            int expeditinId = _ticketService.GetId();
            string Time = _ticketService.GetHour(expeditinId);
            string Date = _ticketService.GetDate(expeditinId);

            var routeTicket = new ExpeditionTickets()
            {
                date = Date,
                time = Time,
                ticket = lastTicket
            };
            return View(routeTicket);
        }*/
    }
}
