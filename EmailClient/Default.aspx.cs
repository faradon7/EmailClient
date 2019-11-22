using System;
using System.Web.UI;
using EmailClient.Interfaces;
using EmailClient.Models;
using EmailClient.Resources;
using EmailClient.Validators;

namespace EmailClient
{
    public partial class _Default : Page
    {
        IMessageValidator _validator;
        public _Default()
        {
            _validator = new MessageValidator();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                NewMessage.Text = StringConstants.NewMessage;
                ToID.Text = StringConstants.To;
                MessageID.Text = StringConstants.InputTextHere;

                if (Context.Session["messageText"] != null )
                {
                    MessageID.Text = Context.Session["messageText"].ToString();
                }

                if (Context.Session["emailAddress"] != null)
                {
                    ToID.Text = Context.Session["emailAddress"].ToString();
                }

                Page.Title = StringConstants.NewMessage;
            }
            else
            {
                Context.Session["messageText"] = MessageID.Text;
                Context.Session["emailAddress"] = ToID.Text;
                var model = new Message();
                model.To = ToID.Text;             //ToDo: model binding;
                model.Text = MessageID.Text;

                if (!_validator.IsValid(model))  //ToDo: (ModelState.IsValid) 
                {
                    Response.Redirect("Default.aspx");
                }
                    SendingForm1._message = model;
            }
        }

        public void SaveToSession()
        { 
        
        }
    }
}