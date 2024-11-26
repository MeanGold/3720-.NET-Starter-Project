// Define a simple Event model in this file or as a separate class
namespace WebApp1.Data.Entities
{
    public class Event
    {
        public int Id { get; set; }
        public required string Title { get; set; }
        public required string Description { get; set; }
        public required string Date { get; set; }
        public required string Time { get; set; }
        public required string Location { get; set; }
    }
}