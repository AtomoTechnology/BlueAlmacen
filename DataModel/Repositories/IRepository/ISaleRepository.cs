using DataModel.Entities;
using DataModel.SPEntities;
using Resolver.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataModel.Repositories.IRepository
{
    public interface ISaleRepository
    {
        List<Sale> GetAll(int state, int page, int top, string orderBy, string ascending, string name, ref int count);
        List<PaymentType> GetAllPaymentType(int state);
        IEnumerable<SearchSaleSP> GetAllSaleHistoric(DateTime datefrom, DateTime dateto);
        Sale GetById(string id);
        IEnumerable<SaleDetailEntityDto> Create(Sale sale);
        String Update(string id, Sale sale);
        String Delete(string id);
        String RemoveNoneSale(string id, string accountId, DeleteSaleEnum enumtype);
    }
}
