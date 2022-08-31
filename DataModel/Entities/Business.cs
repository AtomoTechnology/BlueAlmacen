using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataModel.Entities
{
    public class Business:BaseEntity
    {
        [Required]
        public String BusinessName { get; set; }
        public String Cuit_Cuil { get; set; }
        public String Address { get; set; }
        public String Phone { get; set; }

        public List<User> Users { get; set; }
    }
}
