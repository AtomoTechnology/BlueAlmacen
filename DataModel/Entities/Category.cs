using System;
using System.Collections.Generic;
using System.Text;

namespace DataModel.Entities
{
    public class Category : BaseEntity
    {
        public String AccountId { get; set; }
        public String CategoryName { get; set; }
        public String Description { get; set; }
        public Account Account { get; set; }
        public List<SubCategory> SubCategories { get; set; }
    }
}
