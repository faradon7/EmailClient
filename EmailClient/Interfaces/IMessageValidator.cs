using EmailClient.Models;

namespace EmailClient.Interfaces
{
    public interface IMessageValidator
    {
        bool IsValid(Message model);
    }
}