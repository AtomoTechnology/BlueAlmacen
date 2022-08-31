using DataModel.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataModel.Repositories.IRepository
{
    public interface IRoleRepository
    {
        List<Role> GetAll(int state, int page, int top, string orderBy, string ascending, string name, ref int count);
        Role GetById(string id);
        String Create(Role role);
        String Update(string id, Role role);
        String Delete(string id);
    }
}
