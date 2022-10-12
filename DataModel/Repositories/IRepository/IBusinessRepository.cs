using DataModel.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataModel.Repositories.IRepository
{
    public  interface IBusinessRepository
    {
        List<Business> GetAll(int state, int page, int top, string orderBy, string ascending, string name, ref int count);
        Business GetById(string id);
        Business GetBusinessByUserId(string UserId);
        String Create(Business business);
        String Update(string id, Business business);
        String Delete(string id);
    }
}
