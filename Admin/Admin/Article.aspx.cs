using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Admin.Services;
using Admin.DataContract;

namespace Admin
{
    public partial class Article : System.Web.UI.Page
    {
        private int _articleId;

        public int ArticleId
        {
            get { return _articleId; }
            set { _articleId = value; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                _articleId = int.Parse(Request.Params.Get("id").ToString());
            }
            catch (Exception ex)
            {

            }

            if (!Page.IsPostBack)
            {
                Service service = new Service();
                rcbType.DataSource = service.GetArticleTypes();
                rcbType.DataBind();

                if (_articleId != 0)
                {
                    btnUpdate.Visible = true;
                    ArticleDataContract article = service.GetArticle(_articleId);

                    if (article == null)
                        Response.Redirect("~/Article.aspx");

                    tbName.Text = article.Title;
                    tbDescription.Text = article.Description;
                    tbPrice.Text = article.Price.ToString();
                    rcbType.SelectedValue = article.TypeId.ToString();
                }
                else
                    btnCreate.Visible = true;

            }


        }

        protected void btnUpdate_Click(Object sender, EventArgs e)
        {
            try
            {
                Service service = new Service();

                ArticleDataContract dc = new ArticleDataContract()
                {
                    Id = _articleId,
                    Title = tbName.Text,
                    Description = tbDescription.Text,
                    Price = double.Parse(tbPrice.Text),
                    TypeId = int.Parse(rcbType.SelectedValue)

                };

                service.UpdateArticle(dc);
                Response.Redirect("~/Articles.aspx");
            }
            catch (Exception ex)
            {
                return;
            }
        }

        protected void btnCreate_Click(Object sender, EventArgs e)
        {
            try
            {
                Service service = new Service();

                ArticleDataContract dc = new ArticleDataContract()
                {
                    Title = tbName.Text,
                    Description = tbDescription.Text,
                    Price = double.Parse(tbPrice.Text),
                    TypeId = int.Parse(rcbType.SelectedValue)

                };

                service.CreateArticle(dc);
                Response.Redirect("~/Articles.aspx");
            }
            catch (Exception ex)
            {
                return;
            }
        }

        protected void btnBack_Click(Object sender, EventArgs e)
        {
            Response.Redirect("~/Articles.aspx");
        }
    }
}