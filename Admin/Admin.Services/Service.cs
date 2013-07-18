using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Admin.Interfaces;
using Admin.DataContract;

namespace Admin.Services
{
    public class Service : IService
    {
        public List<ArticleDataContract> GetArticles()
        {
            return Admin.Services.Articles.Articles.GetArticles();
        }

        public ArticleDataContract GetArticle(int id)
        {
            return Admin.Services.Articles.Articles.GetArticle(id);
        }

        public void UpdateArticle(ArticleDataContract article)
        {
            Admin.Services.Articles.Articles.UpdateArticle(article);
        }

        public void CreateArticle(ArticleDataContract article)
        {
            Admin.Services.Articles.Articles.CreateArticle(article);
        }

        public void RemoveArticle(int id)
        {
            Admin.Services.Articles.Articles.RemoveArticle(id);
        }

        public List<ArticleTypeDataContract> GetArticleTypes()
        {
            return Admin.Services.Articles.ArticleTypes.GetArticleTypes();
        }
    }
}
