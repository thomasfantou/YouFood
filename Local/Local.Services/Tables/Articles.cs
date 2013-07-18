using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Local.DataContract;

namespace Local.Services.Tables
{
    public class Articles
    {
        public static List<ArticleDataContract> GetArticles()
        {
            YouFoodDataContext db = new YouFoodDataContext(Local.Library.ConnectionProvider.ConnectionString());

            List<vwGetArticles> view = (from arts in db.vwGetArticles
                                        orderby arts.Type
                                        select arts).ToList();

            return CopyEntitiesToDataContract(view);
        }

        public static List<ArticleTypeDataContract> GetArticleTypes()
        {
            YouFoodDataContext db = new YouFoodDataContext(Local.Library.ConnectionProvider.ConnectionString());

            List<Article_Type> view = (from arts in db.Article_Type
                                        select arts).ToList();

            return CopyEntitiesToDataContract(view);
        }

        public static bool CreateOrder(int idTable, int[] idsArticles)
        {
            try
            {
                YouFoodDataContext db = new YouFoodDataContext(Local.Library.ConnectionProvider.ConnectionString());

                Orders order = new Orders()
                {
                    Id_Status = 2,
                    Id_Table = idTable,
                    Date = DateTime.Now
                };

                db.Orders.InsertOnSubmit(order);
                db.SubmitChanges();

                for (int i = 0; i < idsArticles.Length; i++)
                {
                    Ref_Order_Article refoa = new Ref_Order_Article()
                    {
                        Id_Article = idsArticles[i],
                        Id_Order = order.Id
                    };

                    db.Ref_Order_Article.InsertOnSubmit(refoa);
                    db.SubmitChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        public static List<ArticleDataContract> CopyEntitiesToDataContract(List<vwGetArticles> view)
        {
            List<ArticleDataContract> articles = new List<ArticleDataContract>();

            foreach (vwGetArticles a in view)
            {
                articles.Add(CopyEntityToDataContract(a));
            }

            return articles;
        }

        public static ArticleDataContract CopyEntityToDataContract(vwGetArticles view)
        {
            ArticleDataContract dc = new ArticleDataContract()
            {
                Id = view.Id,
                Title = view.Title,
                Description = view.Description,
                Price = view.Price,
                Type = view.Type,
                TypeId = view.TypeId
            };
            return dc;
        }

        public static List<ArticleTypeDataContract> CopyEntitiesToDataContract(List<Article_Type> view)
        {
            List<ArticleTypeDataContract> articles = new List<ArticleTypeDataContract>();

            foreach (Article_Type a in view)
            {
                articles.Add(CopyEntityToDataContract(a));
            }

            return articles;
        }

        public static ArticleTypeDataContract CopyEntityToDataContract(Article_Type view)
        {
            ArticleTypeDataContract dc = new ArticleTypeDataContract()
            {
                Id = view.Id,
                Title = view.Title
            };
            return dc;
        }
    }
}
