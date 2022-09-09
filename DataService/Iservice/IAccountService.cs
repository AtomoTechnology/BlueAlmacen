using BusnessEntities.BE;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataService.Iservice
{
    public interface IAccountService
    {
        AccountBE Login(string username, string userpass);
        String ChangePassword(AccountBE be);
        String UpdatePassword(string oldpass, AccountBE business);
    }
}
