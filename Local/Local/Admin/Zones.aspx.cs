﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Local.Services;

namespace Local.Admin
{
    public partial class Zones : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Service service = new Service();
            rlvZones.DataSource = service.GetZones();
            rlvZones.DataBind();
        }
    }
}