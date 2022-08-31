using System;
using System.Collections.Generic;
using System.Text;

namespace DataModel.Entities
{
    public class User:BaseEntity
    {
        public String BusinessId { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Email { get; set; }
        public String Phone { get; set; }
        public String Address { get; set; }

        public Business Business { get; set; }

        public List<Account> Accounts { get; set; }
    }
}
