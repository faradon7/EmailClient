using System;
using System.Web.UI;
using Recources;

namespace EmailClient
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Application.InnerText = Resources.Application;
            HomePage.InnerText = Resources.HomePage;
        }
    }
}