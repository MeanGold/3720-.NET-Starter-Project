using System.Linq;
using WebApp1.Data.Entities;
namespace WebApp1.Data
{
    public class TicketRepository : ITicketRepository
    {
        private readonly TigerTixContext _context;
        public TicketRepository(TigerTixContext context)
        {
            _context = context;
        }

        // Create a ticket
        public void BuyTicket(int myEvent, int myCustomer)
        {
            Ticket newTicket = new Ticket() { eventID = myEvent, customerID = myCustomer };
            _context.Add(newTicket);
            _context.SaveChanges();
        }
        // Get all tickets for a user
        public IEnumerable<Ticket> GetAllTicketsForUser(int CustomerIDNumber)
        {
            var tickets = from t in _context.Tickets
                          where t.customerID == CustomerIDNumber
                          select t;
            return tickets;
        }

        public Event GetEventForTicket(int eventIDNumber)
        {
            var eventList = from e in _context.Events
                          where e.Id == eventIDNumber
                          select e;
            Event myEvent = eventList.First();
            return myEvent;
        }

        // Delete a ticket
        public void ReturnTicket(Ticket ticket)
        {
            _context.Remove(ticket);
            _context.SaveChanges();
        }
        /*public void SellTicket(Ticket ticket, User newCustomer)
        {
            ticket.theCustomer = 
            _context.Remove()
        }*/
    }
}
