namespace PortfolioWebsite.Models
{
    public class Education {
        public Guid Id { get; set; }

        public string? NameOfInstitute { get; set; }

        public string? Degree { get; set; }

        public string? Grade { get; set; }

        public DateTime DateStarted { get; set; }

        public DateTime DateGraduated { get; set; }

        public string? InstituteLocation { get; set; }
    }
}