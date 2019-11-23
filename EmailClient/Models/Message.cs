using System.ComponentModel.DataAnnotations;

namespace EmailClient.Models
{
    public class Message
    {
        public string Recipient { get; set; }
        public string Content { get; set; }
    }
}