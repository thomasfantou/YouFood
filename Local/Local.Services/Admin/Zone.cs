using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Local.DataContract;

namespace Local.Services.Admin
{
    public class Zone
    {
        public static List<Local.DataContract.Zone> GetZones()
        {
            YouFoodDataContext db = new YouFoodDataContext(Local.Library.ConnectionProvider.ConnectionString());
            return db.Zone.ToList();
        }
    }
}
