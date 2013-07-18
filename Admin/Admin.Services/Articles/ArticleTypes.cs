using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Admin.DataContract;

namespace Admin.Services.Articles
{
    public class ArticleTypes
    {
        public static List<ArticleTypeDataContract> GetArticleTypes()
        {
            YouFoodDataContext db = new YouFoodDataContext(Admin.Library.ConnectionProvider.ConnectionString());

            List<Article_Type> entities = db.Article_Type.ToList();

            return CopyEntitiesToDataContract(entities);
        }

        private static List<ArticleTypeDataContract> CopyEntitiesToDataContract(List<Article_Type> entities)
        {
            List<ArticleTypeDataContract> dcs = new List<ArticleTypeDataContract>();
            foreach (Article_Type entity in entities)
            {
                ArticleTypeDataContract dc = new ArticleTypeDataContract()
                {
                    Id = entity.Id,
                    Title = entity.Title
                };
                dcs.Add(dc);
            }

            return dcs;
        }
    }
}
