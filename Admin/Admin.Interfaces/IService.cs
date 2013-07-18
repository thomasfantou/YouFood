using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using Admin.DataContract;

namespace Admin.Interfaces
{
    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        List<ArticleDataContract> GetArticles();

        [OperationContract]
        ArticleDataContract GetArticle(int id);

        [OperationContract]
        void UpdateArticle(ArticleDataContract article);

        [OperationContract]
        void CreateArticle(ArticleDataContract article);

        [OperationContract]
        void RemoveArticle(int id);

        

        [OperationContract]
        List<ArticleTypeDataContract> GetArticleTypes();

    }
}
