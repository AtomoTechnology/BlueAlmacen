using Dapper;
using DataModel.Context;
using DataModel.Entities;
using DataModel.Repositories.IRepository;
using DataModel.SPEntities;
using Microsoft.EntityFrameworkCore;
using Resolver.Enums;
using Resolver.HelperError.Handlers;
using Resolver.HelperError.IExceptions;
using System;
using System.Collections.Generic;
using System.Data;
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
        public AccountSP Login(string username, string userpass) {
           
            using (var db = new DbGestionStockContext())
            {
                using (var ctx = db.Database.GetDbConnection())
                {
                        ctx.Open();
                        var values = new
                        {
                            username = username,
                            userpass = userpass
                        };
                        IEnumerable<AccountSP> entity = ctx.Query<AccountSP>("[dbo].[Sp_login]", values, commandType: CommandType.StoredProcedure);
                        ctx.Close();
                    if (entity.Any())
                        return entity.FirstOrDefault();
                    return null;
                }
            }
        }

        public string UpdatePassword(string oldpass, Business business) => throw new NotImplementedException();
    }
}
