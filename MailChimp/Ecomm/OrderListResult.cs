using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MailChimpApiV2.Ecomm
{
    [DataContract]
    public class OrderListResult
    {
        [DataMember(Name = "total")]
        public int Total
        {
            get;
            set;
        }

        [DataMember(Name = "data")]
        public List<OrderResult> Orders
        {
            get;
            set;
        }
    }
}
