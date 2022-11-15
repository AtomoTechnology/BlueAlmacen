using BusnessEntities.BE;
using BusnessEntities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataService.Iservice
{
    public interface ISaleDetailService
    {
        List<SaleDetailBE> GetAll(int state, int page, int top, string orderBy, string ascending, string name, ref int count);
        List<SaleDetailDto> SearchAllDetailByCode(string saleCode);
        SaleDetailBE GetById(string id);
        List<SaleDetailDto> Create(SaleDetailBE saleDetail);
        String Update(string id, SaleDetailBE saleDetail);
        String Delete(string id);
    }
}
