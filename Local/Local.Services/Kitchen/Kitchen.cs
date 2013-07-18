using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Local.DataContract;

namespace Local.Services.Kitchen
{
    public class Kitchen
    {
        private static List<OrderDataContract> orders;
        public static List<DataContract.OrderDataContract> GetKitchenOrders()
        {
            YouFoodDataContext db = new YouFoodDataContext(Local.Library.ConnectionProvider.ConnectionString());
            orders = new List<OrderDataContract>();

            List<vwGetOrders> vwOrders = db.vwGetOrders.Where(o => o.Id_Status <= 6).ToList();

            foreach (vwGetOrders vwOrder in vwOrders)
            {
                CopyEntityToDataContract(vwOrder);
            }

            return orders;

        }

        /// <summary>
        /// We add a new order to our list if it doesnt exist yet, or we just update the article list.
        /// </summary>
        /// <param name="orders"></param>
        /// <param name="vwOrder"></param>
        /// <returns></returns>
        private static void CopyEntityToDataContract(vwGetOrders vwOrder)
        {
            if (orders.Where(o => o.IdOrder == vwOrder.Id).FirstOrDefault() == null)
            {
                OrderDataContract order = new OrderDataContract()
                {
                    IdOrder = vwOrder.Id,
                    IdPayment = vwOrder.Id_Payment,
                    IdStatus = vwOrder.Id_Status,
                    IdTable = vwOrder.Id_Status,
                    IdWaiter = vwOrder.Id_Waiter,
                    StatusDescription = vwOrder.Status,
                    TableName = vwOrder.TableName,
                    PaymentAmount = vwOrder.PaymentAmount,
                    WaiterFirstName = vwOrder.WaiterFirstName,
                    WaiterLastName = vwOrder.WaiterLastName,
                    Date = vwOrder.Date
                };
                ArticleDataContract article = new ArticleDataContract()
                {
                    Title = vwOrder.ArticleName,
                    Description = vwOrder.ArticleDescription,
                    Type = vwOrder.ArticleTypeName,
                    Price = vwOrder.Price
                };
                order.TotalPrice = article.Price;

                order.Articles = new List<ArticleDataContract>();
                order.Articles.Add(article);
                orders.Add(order);
            }
            else
            {
                ArticleDataContract article = new ArticleDataContract()
                {
                    Title = vwOrder.ArticleName,
                    Description = vwOrder.ArticleDescription,
                    Type = vwOrder.ArticleTypeName,
                    Price = vwOrder.Price
                };

                orders.Where(o => o.IdOrder == vwOrder.Id).FirstOrDefault().TotalPrice += article.Price;
                orders.Where(o => o.IdOrder == vwOrder.Id).FirstOrDefault().Articles.Add(article);
            }
        }

        public static void AcceptTheOrder(int id)
        {
            YouFoodDataContext db = new YouFoodDataContext(Local.Library.ConnectionProvider.ConnectionString());

            Orders currentOrder = db.Orders.Where(o => o.Id == id).FirstOrDefault();
            if (currentOrder.Id_Status == 1)
                currentOrder.Id_Status = 3;
            else if (currentOrder.Id_Status == 2)
                currentOrder.Id_Status = 4;

            db.SubmitChanges();
        }

        public static void OrderReady(int id)
        {
            YouFoodDataContext db = new YouFoodDataContext(Local.Library.ConnectionProvider.ConnectionString());

            Orders currentOrder = db.Orders.Where(o => o.Id == id).FirstOrDefault();
            if (currentOrder.Id_Status == 3)
                currentOrder.Id_Status = 5;
            else if (currentOrder.Id_Status == 4)
                currentOrder.Id_Status = 6;

            db.SubmitChanges();
        }
    }
}
