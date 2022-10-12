using System;
using System.Collections.Generic;
using System.Text;

namespace DataModel.Entities
{
    public class HistoryPrice:BaseEntity
    {
        public string ProductId { get; set; }
        public string AccountId { get; set; }   
        public decimal PriceSale { get; set; }
        public decimal PricePurchase { get; set; }
        public Int32 typeUpdate { get; set; }

        public Product Product { get; set; }
        public Account Account { get; set; }
    }
}
