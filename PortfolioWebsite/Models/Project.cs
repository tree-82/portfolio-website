namespace  PortfolioWebsite.Models
{
    public class Project{
        public Guid Id { get; set; }

        public string? ProjectName { get; set; }

        public string? TechStack { get; set; }

        public string? Description { get; set; } 

        public string? ProjectUrl { get; set; }

        public DateTime DateCreated { get; set; }
    }
}