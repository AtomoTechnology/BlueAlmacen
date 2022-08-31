using System;
using System.Collections.Generic;
using System.Text;

namespace DataModel.Entities
{
    public class PaymentType:BaseEntity
    {
        public String AccountId { get; set; }
        public String PaymentName { get; set; }
        public String Description { get; set; }
        public Account Account { get; set; }
    }
}
