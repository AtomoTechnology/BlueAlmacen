using System;
using System.Collections.Generic;
using System.Text;

namespace DataModel.Entities
{
    public class IncreasePriceAfterTwelve:BaseEntity
    {
        public String AccountId { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public Decimal Porcent { get; set; }
        public Boolean IsActive { get; set; }   

        public Account Account { get; set; }

    }
}
