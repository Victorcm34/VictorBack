namespace VictorBack.DTOs
{
    public class JobDTO
    {
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public string Name { get; set; }
        public CompanyDTO Company { get; set; }
    }
}