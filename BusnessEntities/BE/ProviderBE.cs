using System;
using System.Collections.Generic;
using System.Text;

namespace BusnessEntities.BE
{
    public class ProviderBE:BaseBE
    {
        public String AccountId { get; set; }
        public String Name { get; set; }
        public String Address { get; set; }
        public String Phone { get; set; }
        public String Cuit_Cuil { get; set; }

        public AccountBE Account { get; set; }
    }
}
