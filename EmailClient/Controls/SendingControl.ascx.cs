using System;
using System.Web;
using EmailClient.Models;
using EmailClient.Interfaces;
using EmailClient.Validators;
using Recources;

namespace EmailClient.Controls
{
    public partial class SendingControl : System.Web.UI.UserControl
    {
        #region private fields

        private Message _message { get; set; }
        private IMessageValidator _validator;

        #endregion

        public SendingControl()
        {
            _validator = new MessageValidator();
        }


        protected void Page_Load(object sender, EventArgs e)
        {
            var userCookie = Request.Cookies[Resources.HostName];

            if (!IsPostBack)
            {
                NewMessageLabel.Text = Resources.NewMessage;
                Recipient.Text = Resources.To;
                Content.Text = Resources.InputTextHere;

                if (userCookie != null)
                {
                    Content.Text =
                        userCookie[Resources.MessageContent].ToString();
                    Recipient.Text =
                        userCookie[Resources.RecipientEmail].ToString();
                }

                Page.Title = Resources.NewMessage;
            }
        }

        public void SendMail_Click(object sender, EventArgs e)
        {
            var model = new Message();
            model.Recipient = Recipient.Text;
            model.Content = Content.Text;

            HttpCookie cookie = new HttpCookie(Resources.HostName);
            cookie.Expires.AddDays(7);
            cookie[Resources.RecipientEmail] = Recipient.Text;
            cookie[Resources.MessageContent] = Content.Text;
            
            Response.Cookies.Add(cookie);

            if (_validator.IsValid(model))
            {
                _message = model;
                Response.Redirect(Resources.pathSuccessful);
            }
            ValidationMessage.Text = Resources.InvalidInput;
        }
    }
}