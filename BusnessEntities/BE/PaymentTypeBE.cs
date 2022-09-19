using System;
using System.Collections.Generic;
using System.Text;

namespace BusnessEntities.BE
{
    public class PaymentTypeBE:BaseBE
    {
        public String AccountId { get; set; }
        public String PaymentName { get; set; }
        public String Description { get; set; }
        public AccountBE Account { get; set; }
        public List<SaleBE> Sale { get; set; }
    }
}
