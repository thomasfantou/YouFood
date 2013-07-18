using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Telerik.Web.UI;
using Admin.Services;
using Admin.DataContract;
using Admin.BusinessObject;

namespace Admin
{
    public partial class Articles : System.Web.UI.Page
    {
        protected List<ArticlesBo> bos;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Service service = new Service();
                bos = new List<ArticlesBo>();

                //We fill our business object by type, to be able to display by type area
                List<ArticleDataContract> articles = service.GetArticles();
                foreach (ArticleDataContract article in articles)
                {
                    if (bos.Where(o => o.IdType == article.TypeId).FirstOrDefault() == null)
                    {
                        bos.Add(new ArticlesBo()
                        {
                            IdType = article.TypeId,
                            Type = article.Type,
                            Articles = new List<ArticleDataContract>() { article }
                        });
                    }
                    else
                    {
                        bos.Where(o => o.IdType == article.TypeId).FirstOrDefault().Articles.Add(article);
                    }
                }
                repListArticlesType.DataSource = bos;
                repListArticlesType.DataBind();
                repListArticlesTypeCb.DataSource = service.GetArticleTypes();
                repListArticlesTypeCb.DataBind();
            }
        }



        [System.Web.Services.WebMethod]
        public static void DeleteArticle(string id)
        {
            Service service = new Service();
            service.RemoveArticle(int.Parse(id));
        }

        [System.Web.Services.WebMethod]
        public static void SaveArticle(string id, string name, string description, string price, string typeId)
        {
            try
            {
                Service service = new Service();
                if (id != "" && id != null)
                    service.UpdateArticle(new ArticleDataContract() { Id = int.Parse(id), Title = name, Description = description, Price = double.Parse(price), TypeId = int.Parse(typeId) });
                else
                    service.CreateArticle(new ArticleDataContract() { Title = name, Description = description, Price = double.Parse(price), TypeId = int.Parse(typeId) });
            }
            catch (Exception ex)
            {

            }

        }

        
    }
}