using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Admin.DataContract
{
    [DataContract()]
    public class ArticleDataContract
    {
        private int _id;

        [DataMember]
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _title;

        [DataMember]
        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        private string _description;

        [DataMember]
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        private double _price;

        [DataMember]
        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }

        private string _type;

        [DataMember]
        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }

        private int _typeId;

        [DataMember]
        public int TypeId
        {
            get { return _typeId; }
            set { _typeId = value; }
        }
        
    }
}
