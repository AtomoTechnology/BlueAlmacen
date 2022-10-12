using System;
using System.Collections.Generic;
using System.Text;

namespace DataModel.Entities
{
    public class IncreasePriceAfterTwelve:BaseEntity
    {
        public String AccountId { get; set; }
        public DateTime HourFrom { get; set; }
        public DateTime HourTo { get; set; }
        public Decimal Porcent { get; set; }
        public Boolean IsActive { get; set; }   

        public Account Account { get; set; }

    }
}
