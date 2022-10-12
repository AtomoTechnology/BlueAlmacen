using System;
using System.Collections.Generic;
using System.Text;

namespace BusnessEntities.BE
{
    public class LotBE:BaseBE
    {
        public String ProductId { get; set; }
        public String LotCode { get; set; }
        public DateTime ExpiredDate { get; set; }
        public ProductBE Product { get; set; }
    }
}
