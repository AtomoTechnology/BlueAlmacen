using BusnessEntities.BE;
using DataModel.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataService.FactoryPatern
{
    public class UserFactory
    {
        private static UserFactory _factory;
        public static UserFactory GetInstance()
        {
            if (_factory == null)
                _factory = new UserFactory();
            return _factory;
        }

        #region Business
        public UserBE CreateBusiness(User entity)
        {
            UserBE be;
            if (entity != null)
            {
                be = new UserBE()
                {
                    Address = entity.Address,
                    Id = entity.Id,
                    FinalDate = entity.FinalDate,
                    CreatedDate = entity.CreatedDate,
                    state = entity.state,
                    Phone = entity.Phone,
                    LastName = entity.LastName,
                    FirstName = entity.FirstName,
                    Email = entity.Email,
                    BusinessId = entity.BusinessId,
                };
                if (entity.Accounts != null)
                {
                    be.Accounts = new List<AccountBE>();
                    foreach (var item in entity.Accounts)
                    {
                        be.Accounts.Add(AccountFactory.GetInstance().CreateBusiness(item));
                    }
                }
                return be;
            }
            return null;
        }
        #endregion

        #region Entity
        public User CreateEntity(UserBE be)
        {
            User entity;
            if (be != null)
            {
                entity = new User()
                {
                    Address = be.Address,
                    Id = be.Id,
                    FinalDate = be.FinalDate,
                    CreatedDate = be.CreatedDate,
                    state = be.state,
                    Phone = be.Phone,
                    LastName = be.LastName,
                    FirstName = be.FirstName,
                    Email = be.Email,
                    BusinessId = be.BusinessId,
                };
                if (be.Accounts != null)
                {
                    entity.Accounts = new List<Account>();
                    foreach (var item in be.Accounts)
                    {
                        entity.Accounts.Add(AccountFactory.GetInstance().CreateEntity(item));
                    }
                }
                return entity;
            }
            return null;
        }

        #endregion
    }
}
