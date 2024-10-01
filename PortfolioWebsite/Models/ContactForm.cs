namespace PortfolioWebsite.Models
{
    public class ContactForms{
        public Guid Id { get; set; }

        public string? Name { get; set; }

        public string? Email { get; set; }

        public string? Message { get; set; }

        public DateTime MessageDate { get; set; }
    }
}