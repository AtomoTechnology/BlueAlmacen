using System;
using System.Collections.Generic;
using System.Text;

namespace BusnessEntities.BE
{
    public class RoleBE: BaseBE
    {
        public String RoleName { get; set; }
        public String Description { get; set; }
        public List<AccountBE> Accounts { get; set; }
    }
}
