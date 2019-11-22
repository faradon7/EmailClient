using System;
using EmailClient.Models;

namespace EmailClient.Controls
{
    public partial class SendingForm : System.Web.UI.UserControl
    {
        public Message _message { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        public void SendMail_Click(object sender, EventArgs e)
        {
            sendMessage(_message);
            Response.Redirect("Successful.aspx");
        }

        private void sendMessage(Message msg)
        { 
            
        }
    }
}