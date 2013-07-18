using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Admin.DataContract;

namespace Admin.Services.Articles
{
    public class Articles
    {
        public static List<ArticleDataContract> GetArticles()
        {
            YouFoodDataContext db = new YouFoodDataContext(Admin.Library.ConnectionProvider.ConnectionString());

            List<vwGetArticles> view = (from arts in db.vwGetArticles
                                        orderby arts.Type
                                        select arts).ToList();

            return CopyEntitiesToDataContract(view);
        }

        public static ArticleDataContract GetArticle(int id)
        {
            YouFoodDataContext db = new YouFoodDataContext(Admin.Library.ConnectionProvider.ConnectionString());

            vwGetArticles view = (from arts in db.vwGetArticles
                                  where arts.Id == id
                                  select arts).FirstOrDefault();

            return CopyEntityToDataContract(view);
        }

        public static void UpdateArticle(ArticleDataContract article)
        {
            YouFoodDataContext db = new YouFoodDataContext(Admin.Library.ConnectionProvider.ConnectionString());

            Article entity = db.Article.Where(o => o.Id == article.Id).FirstOrDefault();
            entity.Title = article.Title;
            entity.Description = article.Description;
            entity.Price = article.Price;
            entity.Id_Article_Type = article.TypeId;

            db.SubmitChanges();
        }

        public static void CreateArticle(ArticleDataContract article)
        {
            YouFoodDataContext db = new YouFoodDataContext(Admin.Library.ConnectionProvider.ConnectionString());

            Article entity = new Article();
            entity.Title = article.Title;
            entity.Description = article.Description;
            entity.Price = article.Price;
            entity.Id_Article_Type = article.TypeId;

            db.Article.InsertOnSubmit(entity);
            db.SubmitChanges();
        }

        public static void RemoveArticle(int id)
        {
            YouFoodDataContext db = new YouFoodDataContext(Admin.Library.ConnectionProvider.ConnectionString());

            db.Article.DeleteOnSubmit(db.Article.Where(o => o.Id == id).FirstOrDefault());
            db.SubmitChanges();
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

        public static List<ArticleDataContract> CopyEntitiesToDataContract(List<vwGetArticles> view)
        {
            List<ArticleDataContract> articles = new List<ArticleDataContract>();

            foreach (vwGetArticles a in view)
            {
                articles.Add(CopyEntityToDataContract(a));
            }

            return articles;
        }
    }
}
