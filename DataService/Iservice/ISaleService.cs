using BusnessEntities.BE;
using BusnessEntities.Dtos;
using Resolver.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataService.Iservice
{
    public interface ISaleService
    {
        List<SaleBE> GetAll(int state, int page, int top, string orderBy, string ascending, string name, ref int count);
        List<PaymentTypeBE> GetAllPaymentType(int state);
        SaleBE GetById(string id);
        List<SaleDetailDto> Create(SaleBE sale);
        List<SearchSaleSPDTO> GetAllSaleHistoric(DateTime datefrom, DateTime dateto);
        String Update(string id, SaleBE sale);
        String Delete(string id);
        String RemoveNoneSale(string id, string accountId, DeleteSaleEnum enumtype);

    }
}
