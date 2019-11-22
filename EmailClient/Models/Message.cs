using System.ComponentModel.DataAnnotations;

namespace EmailClient.Models
{
    public class Message
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        public string To { get; set; }

        [Required]
        [MinLength(10)]
        public string Text { get; set; }
    }
}