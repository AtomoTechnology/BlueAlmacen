using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationView.Dtos
{
    public  class RoleDto: BaseDto
    {
        public String RoleName { get; set; }
        public String Description { get; set; }
        public List<AccountDto> Accounts { get; set; }
    }
}
