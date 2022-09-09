﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BusnessEntities.BE
{
    public class ProductBE:BaseBE
    {
        public String AccountId { get; set; }
        public String CategoryId { get; set; }
        public String ProductCode { get; set; }
        public String ProductName { get; set; }
        public DateTime ExpirationDate { get; set; }
        public Decimal PurchasePrice { get; set; }
        public Decimal SalePrice { get; set; }
        public String Description { get; set; }
        public AccountBE Account { get; set; }
        public CategoryBE Categories { get; set; }
    }
}
