using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using WebApp1.Data.Entities;
using WebApp1.Data; 


namespace WebApp1.Controllers
{
    public class EventsController : Controller
    {
        // Define a simple list of events in the controller
        /*
        private List<Event> events = new List<Event> {
            new Event { Id = 1, Title = "Clemson Football: Clemson vs. Louisville", Description = "Get ready for an electrifying showdown as Clemson takes on Louisville—experience the thrill of college football at its finest!", Date = "Nov 02, 2024", Time = "7:00 PM", Location = "Clemson, SC" },
            new Event { Id = 2, Title = "Clemson Football: Clemson vs. Virginia", Description = "Don’t miss the action as Clemson battles Virginia in a high-stakes clash—where Tigers roar and champions rise!", Date = "Oct 19, 2024", Time = "1:00 PM", Location = "Clemson, SC" },
            new Event { Id = 3, Title = "Clemson Volleyball: Clemson vs. Duke", Description = "Catch the excitement courtside as Clemson Volleyball faces off against Duke—witness fierce rallies and Tiger pride in action!", Date = "Nov 03, 2024", Time = "3:00 PM", Location = "Duke, NC" },
            new Event { Id = 4, Title = "Clemson Soccer: Clemson vs. UNC", Description = "Join us for an intense soccer match as Clemson takes on UNC—don’t miss the action on the field!", Date = "Nov 10, 2024", Time = "6:30 PM", Location = "Clemson, SC" },
            new Event { Id = 5, Title = "Clemson Basketball: Clemson vs. NC State", Description = "Get ready for a thrilling basketball showdown as Clemson faces NC State—experience the energy courtside!", Date = "Nov 15, 2024", Time = "8:00 PM", Location = "Clemson, SC" }
        };
        */
        private readonly IEventRepository _eventRepository;
        public EventsController(IEventRepository eventRepository)
        {
            _eventRepository = eventRepository;
        }

        public IActionResult Index() {
            var events = from e in _eventRepository.GetAllEvents()
                         select e;

            return View(events.ToList()); // Passes the list to the Index view
        }

        

        public IActionResult EventDetails(int id) {
            var evt = _eventRepository.GetEventByID(id); 
            if (evt == null)
            {
                return NotFound();
            }
            return View(evt); // Passes the selected event to EventDetails view
        }
    }
}