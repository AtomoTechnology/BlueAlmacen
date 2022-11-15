using DataModel.Entities;
using DataModel.SPEntities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataModel.Repositories.IRepository
{
    public interface IAccountRepository
    {
        AccountSP Login(string username, string userpass);
        String ChangePassword(Account entity);
        String UpdatePassword(string oldpass, Business business);
    }
}
