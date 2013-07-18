using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Local.DataContract;

namespace Local.Services.Admin
{
    public class Waiters
    {
        public static List<WaiterDataContact> GetWaiters()
        {
            YouFoodDataContext db = new YouFoodDataContext(Local.Library.ConnectionProvider.ConnectionString());
            return CopyEntitiesToDataContract(db.Waiters.ToList());
        }

        public static List<WaiterDataContact> CopyEntitiesToDataContract(List<DataContract.Waiters> view)
        {
            List<WaiterDataContact> waiters = new List<WaiterDataContact>();

            foreach (DataContract.Waiters t in view)
            {
                waiters.Add(CopyEntityToDataContract(t));
            }

            return waiters;
        }

        public static WaiterDataContact CopyEntityToDataContract(DataContract.Waiters view)
        {
            WaiterDataContact dc = new WaiterDataContact()
            {
                Id = view.Id,
                FirstName = view.FirstName,
                LastName = view.LastName
            };
            return dc;
        }

        public static void SaveWaiter(int id, string firstname, string lastname)
        {
            YouFoodDataContext db = new YouFoodDataContext(Local.Library.ConnectionProvider.ConnectionString());

            //we check if the waiter already exist, or we will create one
            Local.DataContract.Waiters waiter = db.Waiters.Where(o => o.Id == id).FirstOrDefault();
            if (waiter != null)
            {
                waiter.FirstName = firstname;
                waiter.LastName = lastname;

                db.SubmitChanges();
            }
            else
            {
                waiter = new DataContract.Waiters()
                {
                    FirstName = firstname,
                    LastName = lastname
                };
                db.Waiters.InsertOnSubmit(waiter);
                db.SubmitChanges();
            }
        }

        public static void DeleteWaiter(int id)
        {
            YouFoodDataContext db = new YouFoodDataContext(Local.Library.ConnectionProvider.ConnectionString());

            db.Waiters.DeleteOnSubmit(db.Waiters.Where(o => o.Id == id).FirstOrDefault());
            db.SubmitChanges();
        }
    }
}
