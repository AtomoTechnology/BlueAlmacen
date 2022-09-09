using DataModel.Context;
using DataModel.Entities;
using DataModel.Repositories.IRepository;
using Microsoft.EntityFrameworkCore;
using Resolver.Enums;
using Resolver.HelperError.Handlers;
using Resolver.HelperError.IExceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataModel.Repositories.Repository
{
    public class AccountRepository : IAccountRepository
    {
        private readonly DbGestionStockContext _context;
        public AccountRepository(DbGestionStockContext context)
        {
            _context = context;
        }
        public string ChangePassword(Account account) 
        {
            try
            {
                var entity = _context.Accounts.Find(account.Id);
                if (entity == null)
                    throw new ApiBusinessException("3000", "NO existe cuenta para ese usuario con esa contraseña", System.Net.HttpStatusCode.NotFound, "Http");

                entity.UserPass = account.UserPass;
                entity.Confirm = account.Confirm;

                _context.SaveChanges();

                return "La contraseña fue modificada con exito!";
            }
            catch (Exception ex)
            {
                throw HandlerExceptions.GetInstance().RunCustomExceptions(ex);
            }
        }
        public Account Login(string username, string userpass) {
            try
            {
                var entity = _context.Accounts.Include(p => p.Role).SingleOrDefault(u => u.UserName == username && u.UserPass == userpass && u.state == (Int32)StateEnum.Activeted);
                if (entity == null)
                    throw new ApiBusinessException("4000", "Usuario y/o contrasena incorrecto", System.Net.HttpStatusCode.NotFound, "Http");
                return entity;
            }
            catch (Exception ex)
            {
                throw HandlerExceptions.GetInstance().RunCustomExceptions(ex);
            }
        }
        public string UpdatePassword(string oldpass, Business business) => throw new NotImplementedException();
    }
}
