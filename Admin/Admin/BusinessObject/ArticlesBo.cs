using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Admin.DataContract;

namespace Admin.BusinessObject
{
    public class ArticlesBo
    {
        private int _idType;

        public int IdType
        {
            get { return _idType; }
            set { _idType = value; }
        }

        private string _type;

        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }

        private List<ArticleDataContract> _articles;

        public List<ArticleDataContract> Articles
        {
            get { return _articles; }
            set { _articles = value; }
        }
    }
}