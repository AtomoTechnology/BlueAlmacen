using System;
using System.Collections.Generic;
using System.Text;

namespace DataModel.Entities
{
    public class Role : BaseEntity
    {
        public String RoleName { get; set; }
        public String Description { get; set; }
        public List<Account> Accounts { get; set; }
    }
}
