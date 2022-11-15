using BusnessEntities.BE;
using BusnessEntities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataService.Iservice
{
    public interface IAccountService
    {
        AccountDTO Login(string username, string userpass);
        String ChangePassword(AccountBE be);
        String UpdatePassword(string oldpass, AccountBE business);
    }
}
