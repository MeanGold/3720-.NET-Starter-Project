namespace WebApp1.Data.Entities
{
    public class User
    {
        public int Id { get; set; }

        public required string UserName { get; set; }

        public required string FirstName { get; set; }

        public required string LastName { get; set; }
        public required string EmailAddress { get; set; }

        public required string Password { get; set; }

        public required bool ClemsonAffiliate { get; set; }

        public string? CUID_number { get; set; }

        public bool remember_me { get; set; } = false;
    }
}
