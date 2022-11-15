using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataModel.Entities
{
    public class SaleDetailEntityDto
    {
        [NotMapped]
        public String Id { get; set; }
        [NotMapped]
        public String productId { get; set; }
        [NotMapped]
        public String SaleId { get; set; }
        [NotMapped]
        public String ProductCode { get; set; }
        [NotMapped]
        public Int64 InvoiceCode { get; set; }
        [NotMapped]
        public String ProductName { get; set; }
        [NotMapped]
        public Decimal SalePrice { get; set; }
        [NotMapped]
        public Int32 quantity { get; set; }
    }
}
