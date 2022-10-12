using BusnessEntities.BE;
using DataModel.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataService.FactoryPatern
{
    public class PaymentTypeFactory
    {
        private static PaymentTypeFactory _factory;
        public static PaymentTypeFactory GetInstance()
        {
            if (_factory == null)
                _factory = new PaymentTypeFactory();
            return _factory;
        }

        #region Business
        public PaymentTypeBE CreateBusiness(PaymentType entity)
        {
            PaymentTypeBE be;
            if (entity != null)
            {
                be = new PaymentTypeBE()
                {
                    PaymentName = entity.PaymentName,
                    Id = entity.Id,
                    FinalDate = entity.FinalDate,
                    Description = entity.Description,
                    CreatedDate = entity.CreatedDate,
                    state = entity.state,
                    AccountId = entity.AccountId
                };

                return be;
            }
            return null;
        }
        #endregion

        #region Entity
        public PaymentType CreateEntity(PaymentTypeBE be)
        {
            PaymentType entity;
            if (be != null)
            {
                entity = new PaymentType()
                {
                    CreatedDate = be.CreatedDate,
                    Description = be.Description,
                    FinalDate = be.FinalDate,
                    Id = be.Id,
                    PaymentName = be.PaymentName,
                    state = be.state,
                    AccountId = be.AccountId
                };

                return entity;
            }
            return null;
        }

        #endregion
    }
}
