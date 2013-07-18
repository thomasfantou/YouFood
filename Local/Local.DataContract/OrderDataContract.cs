using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Local.DataContract
{
    [DataContract()]
    public class OrderDataContract
    {
        private int _idOrder;

        [DataMember]
        public int IdOrder
        {
            get { return _idOrder; }
            set { _idOrder = value; }
        }

        private int _idStatus;

        [DataMember]
        public int IdStatus
        {
            get { return _idStatus; }
            set { _idStatus = value; }
        }

        private string _statusDescription;

        [DataMember]
        public string StatusDescription
        {
            get { return _statusDescription; }
            set { _statusDescription = value; }
        }

        private int? _idPayment;

        [DataMember]
        public int? IdPayment
        {
            get { return _idPayment; }
            set { _idPayment = value; }
        }

        private int? _paymentAmount;

        [DataMember]
        public int? PaymentAmount
        {
            get { return _paymentAmount; }
            set { _paymentAmount = value; }
        }

        private List<ArticleDataContract> _articles;

        [DataMember]
        public List<ArticleDataContract> Articles
        {
            get { return _articles; }
            set { _articles = value; }
        }

        private int _idTable;

        [DataMember]
        public int IdTable
        {
            get { return _idTable; }
            set { _idTable = value; }
        }

        private string _tableName;

        [DataMember]
        public string TableName
        {
            get { return _tableName; }
            set { _tableName = value; }
        }

        private int? _idWaiter;

        [DataMember]
        public int? IdWaiter
        {
            get { return _idWaiter; }
            set { _idWaiter = value; }
        }

        private string _waiterFirstName;

        [DataMember]
        public string WaiterFirstName
        {
            get { return _waiterFirstName; }
            set { _waiterFirstName = value; }
        }

        private string _waiterLastName;

        [DataMember]
        public string WaiterLastName
        {
            get { return _waiterLastName; }
            set { _waiterLastName = value; }
        }

        private DateTime _date;

        [DataMember]
        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }

        private double _totalPrice;

        [DataMember]
        public double TotalPrice
        {
            get { return _totalPrice; }
            set { _totalPrice = value; }
        }
    }
}
