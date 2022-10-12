using DataModel.Entities;
using Resolver.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataModel.Repositories.IRepository
{
    public interface IProductRepository
    {
        List<Product> GetAll(int state, int page, int top, string orderBy, string ascending, string name, ref int count);
        Product GetById(string id);
        Product SearchProducByCode(string codeRef);
        String Create(Product product);
        String Update(string id, Product product);
        String UpdatePrices(string id, string accountId, decimal porcent, UpdatePriceEnum priceenum, bool ispurchaseprice = false);
        String Delete(string id);
    }
}
