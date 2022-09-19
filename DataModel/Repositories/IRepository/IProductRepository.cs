using DataModel.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataModel.Repositories.IRepository
{
    public interface IProductRepository
    {
        List<Product> GetAll(int state, int page, int top, string orderBy, string ascending, string name, ref int count);
        Product GetById(string id);
        Product SearchProducByCode(string codeRef);
        String Create(Product product);
        String Update(string id, Product product);
        String Delete(string id);
    }
}
