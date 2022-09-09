using System;
using System.Collections.Generic;
using System.Text;

namespace DataModel.Entities
{
    public class Account : BaseEntity
    {
        public String RoleId { get; set; }
        public String UserId { get; set; }
        public String UserName { get; set; }
        public String UserPass { get; set; }
        public Boolean Confirm { get; set; }

        public Role Role { get; set; }
        public User User { get; set; }

        public List<Provider> Providers { get; set; }
        public List<Category> Categories { get; set; }
    }
}
