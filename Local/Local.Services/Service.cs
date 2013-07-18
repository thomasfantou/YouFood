using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Local.Interfaces;

namespace Local.Services
{
    public class Service : IService
    {
        public bool TryRefreshDatabase()
        {
            return Database.Database.TryRefreshDatabase();
        }

        public bool SendDataToDatabase()
        {
            return Database.Database.SendDataToDatabase();
        }

        public bool ForceRefreshDatabase()
        {
            return Database.Database.ForceRefreshDatabase();
        }

        public DateTime GetDateLastUpdate()
        {
            return Database.Database.GetDateLastUpdate();
        }

        public DateTime GetDateLastUpdateAvailable()
        {
            return Database.Database.GetDateLastUpdateAvailable();
        }

        public List<DataContract.OrderDataContract> GetKitchenOrders()
        {
            return Kitchen.Kitchen.GetKitchenOrders();
        }

        public List<DataContract.WaiterDataContact> GetWaiters()
        {
            return Admin.Waiters.GetWaiters();
        }


        public void SaveWaiter(int id, string firstname, string lastname)
        {
            Admin.Waiters.SaveWaiter(id, firstname, lastname);
        }


        public void DeleteWaiter(int id)
        {
            Admin.Waiters.DeleteWaiter(id);
        }


        public List<DataContract.TableDataContract> GetTables()
        {
            return Admin.Table.GetTables();
        }

        public List<DataContract.Zone> GetZones()
        {
            return Admin.Zone.GetZones();
        }


        public void AcceptTheOrder(int id)
        {
            Kitchen.Kitchen.AcceptTheOrder(id);
        }

        public void OrderReady(int id)
        {
            Kitchen.Kitchen.OrderReady(id);
        }


        public List<DataContract.OrderDataContract> GetOrdersByWaiter(int id)
        {
            return Waiters.Waiters.GetOrdersByWaiter(id);
        }

        public void CompleteOrder(int id)
        {
            Waiters.Waiters.CompleteOrder(id);
        }

        public List<DataContract.ArticleDataContract> GetArticles()
        {
            return Tables.Articles.GetArticles();
        }


        public List<DataContract.ArticleTypeDataContract> GetArticleTypes()
        {
            return Tables.Articles.GetArticleTypes();
        }


        public bool CreateOrder(int idTable, int[] idsArticles)
        {
            return Tables.Articles.CreateOrder(idTable, idsArticles);
        }
    }
}
