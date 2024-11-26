using WebApp1.Data.Entities;

namespace WebApp1.Data
{
    public interface IEventRepository
    {
        void CreateEvent(Event myEvent);
        void DeleteEvent(Event myEvent);
        IEnumerable<Event> GetAllEvents();
        Event GetEventByID(int eventID);
        bool SaveAll();
        void UpdateEvent(Event myEvent);
    }
}