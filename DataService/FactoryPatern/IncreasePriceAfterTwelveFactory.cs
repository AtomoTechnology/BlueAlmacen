using BusnessEntities.BE;
using DataModel.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataService.FactoryPatern
{
    public class IncreasePriceAfterTwelveFactory
    {
        private static IncreasePriceAfterTwelveFactory _factory;
        public static IncreasePriceAfterTwelveFactory GetInstance()
        {
            if (_factory == null)
                _factory = new IncreasePriceAfterTwelveFactory();
            return _factory;
        }

        #region Business
        public IncreasePriceAfterTwelveBE CreateBusiness(IncreasePriceAfterTwelve entity)
        {
            IncreasePriceAfterTwelveBE be;
            if (entity != null)
            {
                be = new IncreasePriceAfterTwelveBE()
                {
                    HourFrom = entity.HourFrom,
                    Id = entity.Id,
                    FinalDate = entity.FinalDate,
                    HourTo = entity.HourTo,
                    CreatedDate = entity.CreatedDate,
                    state = entity.state,
                    IsActive = entity.IsActive,
                    AccountId = entity.AccountId,
                    ModifiedDate = entity.ModifiedDate,
                    Porcent = entity.Porcent 
                };

                return be;
            }
            return null;
        }
        #endregion

        #region Entity
        public IncreasePriceAfterTwelve CreateEntity(IncreasePriceAfterTwelveBE be)
        {
            IncreasePriceAfterTwelve entity;
            if (be != null)
            {
                entity = new IncreasePriceAfterTwelve()
                {
                    HourFrom = be.HourFrom,
                    Id = be.Id,
                    FinalDate = be.FinalDate,
                    HourTo = be.HourTo,
                    CreatedDate = be.CreatedDate,
                    state = be.state,
                    IsActive = be.IsActive,
                    AccountId = be.AccountId,
                    ModifiedDate = be.ModifiedDate,
                    Porcent = be.Porcent
                };

                return entity;
            }
            return null;
        }

        #endregion
    }
}
