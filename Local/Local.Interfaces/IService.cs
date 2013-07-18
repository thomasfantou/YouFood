using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using Local.DataContract;

namespace Local.Interfaces
{
    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        bool TryRefreshDatabase();

        [OperationContract]
        bool SendDataToDatabase();

        [OperationContract]
        bool ForceRefreshDatabase();

        [OperationContract]
        List<OrderDataContract> GetKitchenOrders();


        [OperationContract]
        DateTime GetDateLastUpdate(); 

        [OperationContract]
        DateTime GetDateLastUpdateAvailable();

        [OperationContract]
        List<WaiterDataContact> GetWaiters();

        [OperationContract]
        void SaveWaiter(int id, string firstname, string lastname);

        [OperationContract]
        void DeleteWaiter(int id);

        [OperationContract]
        List<TableDataContract> GetTables();

        [OperationContract]
        List<Zone> GetZones();

        [OperationContract]
        void AcceptTheOrder(int id);

        [OperationContract]
        void OrderReady(int id);

        [OperationContract]
        List<OrderDataContract> GetOrdersByWaiter(int id);

        [OperationContract]
        void CompleteOrder(int id);

        [OperationContract]
        List<ArticleTypeDataContract> GetArticleTypes();

        [OperationContract]
        bool CreateOrder(int idTable, int[] idsArticles);
    }
}
