using BusnessEntities.BE;
using Resolver.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataService.Iservice
{
    public interface IProductService
    {
        List<ProductBE> GetAll(int state, int page, int top, string orderBy, string ascending, string name, ref int count);
        ProductBE GetById(string id);
        ProductBE SearchProducByCode(string codeRef, bool ischeckprice = false);
        String Create(ProductBE product);
        String Update(string id, ProductBE product);
        Boolean SearchExpiredProductByLotCode(string lotCode);
        String UpdatePrices(string id, string accountId, decimal porcentsale, decimal porcentpurchase, UpdatePriceEnum priceenum, bool ispurchaseprice = false);
        String Delete(string id);
    }
}
