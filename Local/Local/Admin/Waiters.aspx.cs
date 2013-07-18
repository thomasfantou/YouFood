using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Local.Services;
using System.Text;

namespace Local.Admin
{
    public partial class Waiters : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Service service = new Service();
            rlvWaiters.DataSource = service.GetWaiters();
            rlvWaiters.DataBind();

        }

        protected void btnDelete_Click(Object sender, EventArgs e)
        {
            Service service = new Service();
            Button but = sender as Button;
            service.DeleteWaiter(int.Parse(but.CommandArgument));
            Response.Redirect("~/Admin/Admin.aspx?tab=waiters");
        }

        [System.Web.Services.WebMethod]
        public static void SaveWaiter(string id, string firstname, string lastname)
        {
            Service service = new Service();
            if(id != "" && id != null)
                service.SaveWaiter(int.Parse(id), firstname, lastname);
            else
                service.SaveWaiter(0, firstname, lastname);

            
        }

    }
}