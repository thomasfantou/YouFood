using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Local.DataContract
{
    [DataContract()]
    public class WaiterDataContact
    {
        private int _id;

        [DataMember]
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _firstName;
        private string _lastName;

        [DataMember]
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        [DataMember]
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
    }
}
