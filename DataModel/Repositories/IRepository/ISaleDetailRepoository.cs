using DataModel.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataModel.Repositories.IRepository
{
    public interface ISaleDetailRepoository
    {
        List<SaleDetail> GetAll(int state, int page, int top, string orderBy, string ascending, string name, ref int count);
        List<SaleDetail> SearchAllDetailByCode(string saleCode);
        SaleDetail GetById(string id);
        String Create(SaleDetail saleDetail);
        String Update(string id, SaleDetail saleDetail);
        String Delete(string id);
    }
}
