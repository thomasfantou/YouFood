using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Local.DataContract;
using Local.Services;

namespace YouFoodWS
{
    /// <summary>
    /// Summary description for Service
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServices : System.Web.Services.WebService
    {
        private Service _service;

        public Service Service
        {
            get
            {
                if (_service == null)
                    _service = new Service();
                return _service;
            }
            set { _service = value; }
        }

        [WebMethod]
        public List<ArticleDataContract> getArticles()
        {
            return Service.GetArticles();
        }

        [WebMethod]
        public List<TableDataContract> getTables()
        {
            return Service.GetTables();
        }

        [WebMethod]
        public List<ArticleTypeDataContract> getTypes()
        {
            return Service.GetArticleTypes();
        }

        [WebMethod]
        public List<WaiterDataContact> getWaiters()
        {
            return Service.GetWaiters();
        }

        [WebMethod]
        public bool CreateOrder(int idTable, string idsArticles)
        {
            string[] strs = idsArticles.Split(';');
            int[] articles = new int[strs.Length];

            for (int i = 0; i < strs.Length; i++)
            {
                articles[i] = int.Parse(strs[i]);
            }

            return Service.CreateOrder(idTable, articles);
        }
    }

}