using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Local.Services;
using Local.DataContract;

namespace Local.Kitchen
{
    public partial class Kitchen : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Service service = new Service();

            List<OrderDataContract> orders = service.GetKitchenOrders();
            
            rlvOrdered.DataSource = orders.Where(o => o.IdStatus == 1 || o.IdStatus == 2);
            rlvOrdered.DataBind();

            rlvAccepted.DataSource = orders.Where(o => o.IdStatus == 3 || o.IdStatus == 4);
            rlvAccepted.DataBind();

            rlvReady.DataSource = orders.Where(o => o.IdStatus == 5 || o.IdStatus == 6);
            rlvReady.DataBind();
        }

        protected void btnAcceptOrder_Click(object sender, EventArgs e)
        {
            Service service = new Service();
            Button but = sender as Button;

            service.AcceptTheOrder(int.Parse(but.CommandArgument));

            Response.Redirect("~/Kitchen/Kitchen.aspx?tab=ordered");
        }

        protected void btnOrderReady_Click(object sender, EventArgs e)
        {
            Service service = new Service();
            Button but = sender as Button;

            service.OrderReady(int.Parse(but.CommandArgument));

            Response.Redirect("~/Kitchen/Kitchen.aspx?tab=accepted");
        }
    }
}