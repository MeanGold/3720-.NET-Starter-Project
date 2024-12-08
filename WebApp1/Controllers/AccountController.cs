using Microsoft.AspNetCore.Mvc;
using WebApp1.Data.Entities;
using WebApp1.Data;
using System.Dynamic;

namespace WebApplication1.Controllers
{
    public class AccountController : Controller
    {
        private readonly IUserRepository _userRepository;
        private readonly ITicketRepository _ticketRepository;
        public AccountController(IUserRepository userRepository, ITicketRepository ticketRepository)
        {
            _userRepository = userRepository;
            _ticketRepository = ticketRepository;
        }
        public IActionResult Index(int userID)
        {
            User currUser = _userRepository.GetUsersByID(userID);
            ViewData["username"] = currUser.UserName;
            return View();
        }
        public IActionResult Profile()
        {
            return View();
        }

        public IActionResult Tickets(string username)
        {
            User currUser = _userRepository.GetUsersByUsername(username);
            dynamic myModel = new ExpandoObject();
            myModel.username = currUser.UserName;
            myModel.tickets = _ticketRepository.GetAllTicketsForUser(currUser.Id);

            List<Event> events = new List<Event>();
            foreach (Ticket ticket in myModel.tickets)
            {
                events.Add(_ticketRepository.GetEventForTicket(ticket.eventID));
            }
            myModel.events = events;
            return View(myModel);
        }
        [HttpPost]
        [ActionName("updateUser")]
        public IActionResult Index(User user)
        {

            _userRepository.UpdateUser(user);
            _userRepository.SaveAll();

            return View();
        }
    }
}