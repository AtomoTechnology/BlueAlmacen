using DataModel.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataModel.Repositories.IRepository
{
    public interface IAccountRepository
    {
        Account Login(string username, string userpass);
        String ChangePaaword(string oldpass, string newpass);
        String UpdatePassword(string oldpass, Business business);
    }
}
