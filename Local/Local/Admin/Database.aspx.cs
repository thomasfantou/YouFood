using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Local.Services;

namespace Local.Admin
{
    public partial class Database : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Service service = new Service();

            //Getting date from last update server & client, display a message to user to let him know if current database is up/out to date.
            DateTime lastUpdate = service.GetDateLastUpdate();
            DateTime lastUpdateAvailable = service.GetDateLastUpdateAvailable();
            lbLastUpdate.Text = lbLastUpdate.Text.Replace("{0}", String.Format("{0:F}", lastUpdate));
            lbLastUpdateAvailable.Text = lbLastUpdateAvailable.Text.Replace("{0}", String.Format("{0:F}", lastUpdateAvailable));

            if (lastUpdate == lastUpdateAvailable)
            {
                lbUpdateMessage.Text = "Current database is up to date";
                lbUpdateMessage.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                lbUpdateMessage.Text = "Current database is out of date";
                lbUpdateMessage.ForeColor = System.Drawing.Color.Red;
            }
        }

        protected void btnForceUpdate_Click(Object sender, EventArgs e)
        {
            Service service = new Service();
            bool success = service.ForceRefreshDatabase();

            Response.Redirect("~/Admin/Admin.aspx?tab=database");
        }
    }
}