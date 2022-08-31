using DataModel.Entities;
using DataModel.Repositories.IRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataModel.Repositories.Repository
{
    public class SaleRepository : ISaleRepository
    {
        public string Create(Sale product) => throw new NotImplementedException();
        public string Delete(string id) => throw new NotImplementedException();
        public List<Sale> GetAll(int state, int page, int top, string orderBy, string ascending, string name, ref int count) => throw new NotImplementedException();
        public Sale GetById(string id) => throw new NotImplementedException();
        public string Update(string id, Sale product) => throw new NotImplementedException();
    }
}
