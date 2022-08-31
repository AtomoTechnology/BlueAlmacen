using DataModel.Entities;
using DataModel.Repositories.IRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataModel.Repositories.Repository
{
    public class SaleDetailRepoository : ISaleDetailRepoository
    {
        public string Create(SaleDetail saleDetail) => throw new NotImplementedException();
        public string Delete(string id) => throw new NotImplementedException();
        public List<SaleDetail> GetAll(int state, int page, int top, string orderBy, string ascending, string name, ref int count) => throw new NotImplementedException();
        public SaleDetail GetById(string id) => throw new NotImplementedException();
        public string Update(string id, SaleDetail saleDetail) => throw new NotImplementedException();
    }
}
