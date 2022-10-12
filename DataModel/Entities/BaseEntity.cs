using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataModel.Entities
{
    public class BaseEntity
    {
        [Key]
        public String Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? FinalDate { get; set; }
        public Int32 state { get; set; }
    }
}
