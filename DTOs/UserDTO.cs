using System.Net.Mail;

namespace VictorBack.DTOs
{
    public class UserDTO
    {
        public string Presentation { get; set; }
        public DateTime Birthday { get; set; }
        public string Name { get; set; }
        public List<string> Interests { get; set; }
        public MailAddress Email { get; set; }
        public Dictionary<string,string> SocialMedia { get; set; }
    }
}