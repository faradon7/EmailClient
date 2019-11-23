using System;
using System.Web.UI;

namespace EmailClient
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SuccessFulMessage.Text = Recources.Resources.MesageSuccessful;
        }
    }
}