using BusnessEntities.BE;
using DataModel.Entities;
using Resolver.Security;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataService.FactoryPatern
{
    public class AccountFactory
    {
        private static AccountFactory _factory;
        public static AccountFactory GetInstance()
        {
            if (_factory == null)
                _factory = new AccountFactory();
            return _factory;
        }

        #region Business
        public AccountBE CreateBusiness(Account entity)
        {
            AccountBE be;
            if (entity != null)
            {
                be = new AccountBE()
                {
                    Id = entity.Id,
                    FinalDate = entity.FinalDate,
                    CreatedDate = entity.CreatedDate,
                    state = entity.state,
                    RoleId = entity.RoleId,
                    UserId = entity.UserId,
                    UserName = entity.UserName,
                    UserPass = PassValidation.GetInstance().Decrypt(entity.UserPass),
                    Confirm = entity.Confirm
                };
                if (entity.Role != null)
                {
                    be.Role = new RoleBE();
                    be.Role = RoleFactory.GetInstance().CreateBusiness(entity.Role);
                }
                return be;
            }
            return null;
        }
        #endregion

        #region Entity
        public Account CreateEntity(AccountBE be)
        {
            Account entity;
            if (be != null)
            {
                entity = new Account()
                {
                    Id = be.Id,
                    FinalDate = be.FinalDate,
                    CreatedDate = be.CreatedDate,
                    state = be.state,
                    RoleId = be.RoleId,
                    UserId = be.UserId,
                    UserName = be.UserName,
                    Confirm = be.Confirm,
                    UserPass = be.UserPass != null ? PassValidation.GetInstance().Encypt(be.UserPass) : null,
                };

                return entity;
            }
            return null;
        }

        #endregion
    }
}
