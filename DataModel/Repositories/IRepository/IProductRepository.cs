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
        Product SearchProducByCode(string codeRef, bool ischeckprice = false);
        String Create(Product product);
        String Update(string id, Product product);
        Boolean SearchExpiredProductByLotCode(string lotCode);
        String UpdatePrices(string id, string accountId, decimal porcentsale, decimal porcentpurchase, UpdatePriceEnum priceenum, bool ispurchaseprice = false);
        String Delete(string id);
    }
}
