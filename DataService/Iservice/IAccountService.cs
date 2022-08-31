using BusnessEntities.BE;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataService.Iservice
{
    public interface IAccountService
    {
        AccountBE Login(string username, string userpass);
        String ChangePaaword(string oldpass, string newpass);
        String UpdatePassword(string oldpass, AccountBE business);
    }
}
