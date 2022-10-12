using System;
using System.Collections.Generic;
using System.Text;

namespace DataModel.Entities
{
    public class History:BaseEntity
    {
        public String AccountId { get; set; }
        public String OptionId { get; set; }
        public Int32 TypeId { get; set; }
        public String Action { get; set; }
        public String ModuleAction { get; set; }

        public Account Account { get; set; }

    }
}
