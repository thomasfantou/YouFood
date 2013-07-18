using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Local.DataContract;

namespace Local.Services.Admin
{
    public class Table
    {
        public static List<TableDataContract> GetTables()
        {
            YouFoodDataContext db = new YouFoodDataContext(Local.Library.ConnectionProvider.ConnectionString());
            return CopyEntitiesToDataContract(db.Table.ToList());
        }

        public static List<TableDataContract> CopyEntitiesToDataContract(List<DataContract.Table> view)
        {
            List<TableDataContract> tables = new List<TableDataContract>();

            foreach (DataContract.Table t in view)
            {
                tables.Add(CopyEntityToDataContract(t));
            }

            return tables;
        }

        public static TableDataContract CopyEntityToDataContract(DataContract.Table view)
        {
            TableDataContract dc = new TableDataContract()
            {
                Id = view.Id,
                Title = view.Title
            };
            return dc;
        }
    }
}
