using System;
using System.Collections.Generic;
using System.Text;

namespace BusnessEntities.BE
{
    public class UserBE: BaseBE
    {
        public String BusinessId { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Email { get; set; }
        public String Phone { get; set; }
        public String Address { get; set; }

        public BusinessBE Business { get; set; }

        public List<AccountBE> Accounts { get; set; }
    }
}
