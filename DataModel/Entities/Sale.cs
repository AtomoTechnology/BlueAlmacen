using System;
using System.Collections.Generic;
using System.Text;

namespace DataModel.Entities
{
    public class Sale: BaseEntity
    {
        public String AccountId { get; set; }
        public String? PaymentTypeId { get; set; }
        public Int64 InvoiceCode { get; set; }
        public Decimal Total { get; set; }
        public Boolean finalizeSale { get; set; }
        public String SaleType { get; set; }

        public PaymentType PaymentType { get; set; }
        public List<SaleDetail> SaleDetail { get; set; }
    }
}
