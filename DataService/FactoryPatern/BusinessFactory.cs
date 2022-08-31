using BusnessEntities.BE;
using DataModel.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataService.FactoryPatern
{
    public class BusinessFactory
    {
        private static BusinessFactory _factory;
        public static BusinessFactory GetInstance()
        {
            if (_factory == null)
                _factory = new BusinessFactory();
            return _factory;
        }

        #region Business
        public BusinessBE CreateBusiness(Business entity)
        {
            BusinessBE be;
            if (entity != null)
            {
                be = new BusinessBE()
                {
                    Address = entity.Address,
                    Id = entity.Id,
                    FinalDate = entity.FinalDate,
                    BusinessName = entity.BusinessName,
                    CreatedDate = entity.CreatedDate,
                    state = entity.state,
                    Cuit_Cuil = entity.Cuit_Cuil,
                    Phone = entity.Phone
                };
                if (entity.Users != null)
                {
                    be.Users = new List<UserBE>();
                    foreach (var item in entity.Users)
                    {
                        be.Users.Add(UserFactory.GetInstance().CreateBusiness(item));
                    }
                }
                return be;
            }
            return null;
        }
        #endregion

        #region Entity
        public Business CreateEntity(BusinessBE be)
        {
            Business entity;
            if (be != null)
            {
                entity = new Business()
                {
                    Address = be.Address,
                    Id = be.Id,
                    FinalDate = be.FinalDate,
                    BusinessName = be.BusinessName,
                    CreatedDate = be.CreatedDate,
                    state = be.state,
                    Cuit_Cuil = be.Cuit_Cuil,
                    Phone = be.Phone,
                };
                if (be.Users != null)
                {
                    entity.Users = new List<User>();
                    foreach (var item in be.Users)
                    {
                        entity.Users.Add(UserFactory.GetInstance().CreateEntity(item));
                    }
                }

                return entity;
            }
            return null;
        }

        #endregion
    }
}
