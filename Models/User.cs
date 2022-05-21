using System.Net.Mail;
using VictorBack.DTOs;

namespace VictorBack.Models
{
    public class User : UserDTO
    {
        public Guid Id { get; set; }
    }
}