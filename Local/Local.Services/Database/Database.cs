using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Local.DataContract;

namespace Local.Services.Database
{
    public class Database
    {
        public static bool TryRefreshDatabase()
        {
            //Connection of the 2 databases
            YouFoodDataContext db = new YouFoodDataContext(Local.Library.ConnectionProvider.ConnectionString());
            Local.Server.YouFoodDataContext sdb = new Local.Server.YouFoodDataContext(Local.Library.ConnectionProvider.ServerConnectionString());

            //We get last update to check if we need to update local database
            DateTime dateLastUpdate = GetDateLastUpdate();

            List<Local.Server.Database_Changes> recentChanges = sdb.Database_Changes.Where(o => o.Date > dateLastUpdate).ToList();
            if (recentChanges != null && recentChanges.Count != 0)
            {
                bool articleNeedUpdate = false;

                foreach (Local.Server.Database_Changes changes in recentChanges)
                {
                    //First we'll log changes in local database
                    db.Database_Changes.InsertOnSubmit(new Database_Changes() { Date = changes.Date, Article_changed = changes.Article_changed});
                    db.SubmitChanges();

                    if (changes.Article_changed)
                        articleNeedUpdate = true;
                }

                //we proceed to update if needed
                if (articleNeedUpdate)
                {
                    UpdateArticleData();
                }

            }

            return true;
        }

        public static bool ForceRefreshDatabase()
        {
            YouFoodDataContext db = new YouFoodDataContext(Local.Library.ConnectionProvider.ConnectionString());
            Local.Server.YouFoodDataContext sdb = new Local.Server.YouFoodDataContext(Local.Library.ConnectionProvider.ServerConnectionString());
            List<Local.Server.Database_Changes> changes = sdb.Database_Changes.ToList();

            //First we'll log changes in local database
            db.Database_Changes.InsertOnSubmit(new Database_Changes() { Date = changes.Last().Date, Article_changed = changes.Last().Article_changed });
            db.SubmitChanges();

            UpdateArticleData();

            return true;
        }

        public static DateTime GetDateLastUpdate()
        {
            YouFoodDataContext db = new YouFoodDataContext(Local.Library.ConnectionProvider.ConnectionString());
            DateTime lastChanges = new DateTime(1970,1,1);
            List<Database_Changes> entity = db.Database_Changes.ToList();

            if (entity != null && entity.Count != 0)
            {
                lastChanges = entity.Last().Date;
            }

            return lastChanges;
        }

        public static DateTime GetDateLastUpdateAvailable()
        {
            Local.Server.YouFoodDataContext sdb = new Local.Server.YouFoodDataContext(Local.Library.ConnectionProvider.ServerConnectionString());
            DateTime lastChanges = new DateTime(1970, 1, 1);
            List<Local.Server.Database_Changes> entity = sdb.Database_Changes.ToList();

            if (entity != null && entity.Count != 0)
            {
                lastChanges = entity.Last().Date;
            }

            return lastChanges;
        }

        private static void UpdateArticleData()
        {
            YouFoodDataContext db = new YouFoodDataContext(Local.Library.ConnectionProvider.ConnectionString());
            Local.Server.YouFoodDataContext sdb = new Local.Server.YouFoodDataContext(Local.Library.ConnectionProvider.ServerConnectionString());

            //we delete table
            db.Article.DeleteAllOnSubmit(db.Article.ToList());
            db.SubmitChanges();

            List<Local.Server.Article> serverArticles = sdb.Article.ToList();

            foreach (Local.Server.Article serverArticle in serverArticles)
            {
                Article article = new Article()
                {
                    Id = serverArticle.Id,
                    Title = serverArticle.Title,
                    Description = serverArticle.Description,
                    Price = serverArticle.Price,
                    Id_Article_Type = serverArticle.Id_Article_Type
                };

                db.Article.InsertOnSubmit(article);
                db.SubmitChanges();
            }
        }

        public static bool SendDataToDatabase()
        {
            //TODO
            return false;
        }

    }
}
