using System;
using System.Collections.Generic;
using System.Text;

namespace BusnessEntities.BE
{
    public class IncreasePriceAfterTwelveBE:BaseBE
    {
        public String AccountId { get; set; }
        public DateTime HourFrom { get; set; }
        public DateTime HourTo { get; set; }
        public Decimal Porcent { get; set; }
        public Boolean IsActive { get; set; }

        public AccountBE Account { get; set; }
    }
}
