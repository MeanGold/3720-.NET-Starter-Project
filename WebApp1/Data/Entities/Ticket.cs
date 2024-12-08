namespace WebApp1.Data.Entities
{
    public class Ticket
    {
        public int Id { get; set; }
        public required int eventID { get; set; }
        public required int customerID { get; set; }
    }
}
