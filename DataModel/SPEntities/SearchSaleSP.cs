using System;
using System.Collections.Generic;
using System.Text;

namespace DataModel.SPEntities
{
    public class SearchSaleSP
    {
        public string ProductCode { get; set; }
        public String ProductName { get; set; }
        public int InvoiceCode { get; set; }
        public String PaymentName { get; set; }
        public decimal price { get; set; }
        public int quantity { get; set; }
    }
}
