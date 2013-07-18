using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Local.Services;

namespace Local.Waiters
{
    public partial class Waiters : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Service service = new Service();
            List<Local.DataContract.WaiterDataContact> waiters = service.GetWaiters();
            repListWaiters.DataSource = waiters;
            repListWaiters.DataBind();

        }

        public static int CurrentIndex;
        [System.Web.Services.WebMethod]
        public static void CacheCurrentWaiter(string index)
        {
            CurrentIndex = int.Parse(index);
        }
    }
}