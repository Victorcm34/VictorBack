namespace VictorBack.Models
{
    public class Job
    {
        public Guid Id { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public string Name { get; set; }
        public Company Company { get; set; }
    }
}