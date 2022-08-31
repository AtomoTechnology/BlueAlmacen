using System;
using System.Collections.Generic;
using System.Text;

namespace DataModel.Entities
{
    public class Sale: BaseEntity
    {
        public String AccountId { get; set; }
        public Decimal total { get; set; }
    }
}
