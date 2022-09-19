﻿using BusnessEntities.BE;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataService.Iservice
{
    public interface IProductService
    {
        List<ProductBE> GetAll(int state, int page, int top, string orderBy, string ascending, string name, ref int count);
        ProductBE GetById(string id);
        ProductBE SearchProducByCode(string codeRef);
        String Create(ProductBE product);
        String Update(string id, ProductBE product);
        String Delete(string id);
    }
}
