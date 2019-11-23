using EmailClient.Interfaces;
using EmailClient.Models;
using System.Text.RegularExpressions;

namespace EmailClient.Validators
{
    public class MessageValidator : IMessageValidator
    {
        public bool IsValid(Message model)
        {
            return validateEmailAddress(model.Recipient)
                && validateMessageLength(model.Content);
        }

        private bool validateEmailAddress(string emailAddress)
        {
            string pattern = "[.\\-_a-z0-9]+@([a-z0-9][\\-a-z0-9]+\\.)+[a-z]{2,6}";
            Match isMatch = Regex.Match(emailAddress, pattern, RegexOptions.IgnoreCase);
            var result = !string.IsNullOrEmpty(emailAddress) 
                && isMatch.Success
                && (emailAddress.Length < 320);

            return result;
        }

        private bool validateMessageLength(string messageText)
        {
            return messageText.Length >= 10;
        }
    }
}