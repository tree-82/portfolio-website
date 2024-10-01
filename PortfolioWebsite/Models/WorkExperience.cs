namespace PortfolioWebsite.Models
{
    public class WorkExperience {
        public Guid Id { get; set; }

        public string? CompanyName { get; set; }

        public string? JobDescription { get; set; }

        public string? JobTitle { get; set; }

        public DateTime DateStarted { get; set; }

        public DateTime CompletionDate { get; set; }
    }
}