using System;
using System.Collections.Generic;
using System.Text;

namespace DataModel.Entities
{
    public class Product : BaseEntity
    {
        public String AccountId { get; set; }
        public String ProviderId { get; set; }
        public String CategoryId { get; set; }
        public String ProductCode { get; set; }
        public String ProductName { get; set; }     
        public Decimal PurchasePrice { get; set; }
        public Decimal SalePrice { get; set; }
        public  Int32 Stock { get; set; }
        public String Description { get; set; }
        public Account Account { get; set; }
        public Provider Provider { get; set; }
        public Category Categories { get; set; }
        public List<Lot> Lots { get; set; }
        public List<HistoryPrice> HistoryPrice { get; set; }
        
    }
}
