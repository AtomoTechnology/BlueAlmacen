using DataModel.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataModel.Repositories.IRepository
{
    public interface ISaleRepository
    {
        List<Sale> GetAll(int state, int page, int top, string orderBy, string ascending, string name, ref int count);
        Sale GetById(string id);
        String Create(Sale product);
        String Update(string id, Sale product);
        String Delete(string id);
    }
}
