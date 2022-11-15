using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusnessEntities.Dtos
{
    public class SearchSaleSPDTO
    {
        public string ProductCode { get; set; }
        public String ProductName { get; set; }
        public int InvoiceCode { get; set; }
        public String PaymentName { get; set; }
        public decimal price { get; set; }
        public int quantity { get; set; }
    }
}
