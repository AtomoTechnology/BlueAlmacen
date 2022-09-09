using BusnessEntities.BE;
using DataModel.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataService.FactoryPatern
{
    public class ProviderFactory
    {
        private static ProviderFactory _factory;
        public static ProviderFactory GetInstance()
        {
            if (_factory == null)
                _factory = new ProviderFactory();
            return _factory;
        }

        #region Business
        public ProviderBE CreateBusiness(Provider entity)
        {
            ProviderBE be;
            if (entity != null)
            {
                be = new ProviderBE()
                {
                    Id = entity.Id,
                    FinalDate = entity.FinalDate,
                    CreatedDate = entity.CreatedDate,
                    state = entity.state,
                    Name = entity.Name,
                    AccountId = entity.AccountId,
                    Address = entity.Address,
                    Cuit_Cuil = entity.Cuit_Cuil,
                    Phone = entity.Phone,
                };
                return be;
            }
            return null;
        }
        #endregion

        #region Entity
        public Provider CreateEntity(ProviderBE be)
        {
            Provider entity;
            if (be != null)
            {
                entity = new Provider()
                {
                    Id = be.Id,
                    FinalDate = be.FinalDate,
                    CreatedDate = be.CreatedDate,
                    state = be.state,
                    Name = be.Name,
                    AccountId = be.AccountId,
                    Address = be.Address,
                    Cuit_Cuil = be.Cuit_Cuil,
                    Phone = be.Phone,
                };

                return entity;
            }
            return null;
        }

        #endregion
    }
}
