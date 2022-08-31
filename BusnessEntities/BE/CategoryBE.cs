using System;
using System.Collections.Generic;
using System.Text;

namespace BusnessEntities.BE
{
    public class Category: BaseBE
    {
        public String AccountId { get; set; }
        public String CategoryName { get; set; }
        public String Description { get; set; }
        public AccountBE Account { get; set; }
    }
}
