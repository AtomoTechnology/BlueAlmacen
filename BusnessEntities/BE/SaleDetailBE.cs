using System;
using System.Collections.Generic;
using System.Text;

namespace BusnessEntities.BE
{
    public class SaleDetailBE:BaseBE
    {
        public String productId { get; set; }
        public String SaleId { get; set; }
        public decimal price { get; set; }
        public Int32 quantity { get; set; }
        public ProductBE Product { get; set; }
    }
}
