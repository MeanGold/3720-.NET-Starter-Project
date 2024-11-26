using WebApp1.Data.Entities;
using WebApp1.Data;
namespace WebApp1.Data
{
    public class EventRepository : IEventRepository
    {
        private readonly TigerTixContext _context;
        public EventRepository(TigerTixContext context)
        {
            _context = context;
        }

        // Create a User
        public void CreateEvent(Event myEvent)
        {
            _context.Add(myEvent);
            _context.SaveChanges();
        }

        // Returns all users
        public IEnumerable<Event> GetAllEvents()
        {
            var events = from u in _context.Events
                         select u;
            return events.ToList();
        }

        public Event GetEventByID(int eventID)
        {
            var myEvent = (from u in _context.Events
                           where u.Id == eventID
                           select u).FirstOrDefault();
            return myEvent;
        }

        // Update a user
        public void UpdateEvent(Event myEvent)
        {
            _context.Update(myEvent);
            _context.SaveChanges();
        }

        // Delete a user
        public void DeleteEvent(Event myEvent)
        {
            _context.Remove(myEvent);
            _context.SaveChanges();
        }

        public bool SaveAll()
        {
            return _context.SaveChanges() > 0;
        }
    }
}
