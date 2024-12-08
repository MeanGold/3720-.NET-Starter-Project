using WebApp1.Data.Entities;

namespace WebApp1.Data
{
    public interface ITicketRepository
    {
        void BuyTicket(int myEvent, int myCustomer);
        IEnumerable<Ticket> GetAllTicketsForUser(int CustomerIDNumber);
        Event GetEventForTicket(int eventIDNumber);
        void ReturnTicket(Ticket ticket);
    }
}