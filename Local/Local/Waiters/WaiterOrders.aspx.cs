using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Local.Services;
using Local.DataContract;

namespace Local.Waiters
{
    public partial class WaiterOrders : System.Web.UI.Page
    {
        private int _currentWaiterId;

        public int CurrentWaiterId
        {
            get { return _currentWaiterId; }
            set { _currentWaiterId = value; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            Service service = new Service();

            if (Request.Params.Get("id") != null)
                _currentWaiterId = int.Parse(Request.Params.Get("id").ToString());

            List<OrderDataContract> orders = service.GetOrdersByWaiter(_currentWaiterId);

            rlvOrdersNotReady.DataSource = orders.Where(o => o.IdStatus >= 0 && o.IdStatus <= 4);
            rlvOrdersNotReady.DataBind();

            rlvOrdersReady.DataSource = orders.Where(o => o.IdStatus == 5 || o.IdStatus == 6);
            rlvOrdersReady.DataBind();

            rlvOrdersUnpaid.DataSource = orders.Where(o => o.IdStatus == 7);
            rlvOrdersUnpaid.DataBind();
        }

        protected void btnComplete_Click(object sender, EventArgs e)
        {
            Service service = new Service();
            Button but = sender as Button;
            service.CompleteOrder(int.Parse(but.CommandArgument));
            Response.Redirect("~/Waiters/Waiters.aspx");
        }

        [System.Web.Services.WebMethod]
        public static void CompleteOrder(string id)
        {
            Service service = new Service();
            if (id != "" && id != null)
                service.CompleteOrder(int.Parse(id));
        }
    }
}