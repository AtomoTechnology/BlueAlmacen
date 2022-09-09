using DataModel.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataModel.Repositories.IRepository
{
    public interface IProviderRepository
    {
        List<Provider> GetAll(int state, int page, int top, string orderBy, string ascending, string name, ref int count);
        Provider GetById(string id);
        String Create(Provider provider);
        String Update(string id, Provider provider);
        String Delete(string id);
    }
}
