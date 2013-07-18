using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Local.DataContract;

namespace Local.Services.Waiters
{
    public class Waiters
    {
        private static List<OrderDataContract> orders;
        public static List<DataContract.OrderDataContract> GetOrdersByWaiter(int id)
        {
            YouFoodDataContext db = new YouFoodDataContext(Local.Library.ConnectionProvider.ConnectionString());
            orders = new List<OrderDataContract>();

            List<vwGetOrders> vwOrders = db.vwGetOrders.Where(o => o.Id_Waiter == id).ToList();

            if (vwOrders != null)
            {
                foreach (vwGetOrders vwOrder in vwOrders)
                {
                    CopyEntityToDataContract(vwOrder);
                }
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

        public static void CompleteOrder(int id)
        {
            YouFoodDataContext db = new YouFoodDataContext(Local.Library.ConnectionProvider.ConnectionString());

            Orders order = db.Orders.Where(o => o.Id == id).FirstOrDefault();

            if (order != null)
            {
                if (order.Id_Status == 6)
                    order.Id_Status = 7;
                else
                    order.Id_Status = 8;
            }

            db.SubmitChanges();
        }
    }
}
