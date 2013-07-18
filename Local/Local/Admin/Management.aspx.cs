using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Local.Services;
using Local.DataContract;

namespace Local.Admin
{
    public partial class Management : System.Web.UI.Page
    {
        private List<Zone> _zones;
        public List<Zone> Zones
        {
            get { return _zones; }
            set { _zones = value; }
        }

        private List<Local.DataContract.WaiterDataContact> _waiters;
        public List<Local.DataContract.WaiterDataContact> Waiters
        {
            get { return _waiters; }
            set { _waiters = value; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            Service service = new Service();
            _zones = service.GetZones();
            rlvZones.DataSource = _zones;
            rlvZones.DataBind();

            rlvTables.DataSource = service.GetTables();
            rlvZones.DataBind();

            _waiters = service.GetWaiters();
        }

        protected int GetWaiterId(int zoneId)
        {
            return _zones.Where(o => o.Id == zoneId).FirstOrDefault().Id_Waiters;
        }
    }
}