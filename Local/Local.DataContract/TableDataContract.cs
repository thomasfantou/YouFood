using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Local.DataContract
{
    [DataContract()]
    public class TableDataContract
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
    }
}
