namespace PortfolioWebsite.Models
{
    public class Certification {
        public Guid Id { get; set; }

        public string? CertificationName { get; set; }

        public string? CertificationProvider { get; set; }

        public DateTime DateOfCertification { get; set; }
    }
}