using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationView.Dtos
{
    public class BaseDto
    {
        public String Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? FinalDate { get; set; }
        public Int32 state { get; set; }
    }
}
