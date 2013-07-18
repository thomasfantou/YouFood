using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Local
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Daemon.DatabaseSync.StartSync();
            //Response.Redirect("~/Admin/Admin.aspx");
        }

        protected void btnKitchen_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Kitchen/Kitchen.aspx");
        }

        protected void btnWaiters_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Waiters/Waiters.aspx");
        }

        protected void btnAdmin_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Admin/Admin.aspx");
        }
    }
}