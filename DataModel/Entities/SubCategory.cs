using System;
using System.Collections.Generic;
using System.Text;

namespace DataModel.Entities
{
    public class SubCategory : BaseEntity
    {
        public String CategoryId { get; set; }
        public String SubCategoryName { get; set; }
        public String Description { get; set; }
        public Category Category { get; set; }
    }
}
