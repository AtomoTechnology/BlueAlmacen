using System;
using System.Collections.Generic;
using System.Text;

namespace BusnessEntities.BE
{
    public class AccountBE:BaseBE
    {
        public String RoleId { get; set; }
        public String UserId { get; set; }
        public String UserName { get; set; }
        public String UserPass { get; set; }
        public bool confirm { get; set; }

        public RoleBE Role { get; set; }
        public UserBE User { get; set; }

        public List<ProviderBE> Providers { get; set; }
    }
}
