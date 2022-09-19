using BusnessEntities.BE;
using DataModel.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataService.FactoryPatern
{
    public class SaleDetailFactory
    {
        private static SaleDetailFactory _factory;
        public static SaleDetailFactory GetInstance()
        {
            if (_factory == null)
                _factory = new SaleDetailFactory();
            return _factory;
        }

        #region Business
        public SaleDetailBE CreateBusiness(SaleDetail entity)
        {
            SaleDetailBE be;
            if (entity != null)
            {
                be = new SaleDetailBE()
                {
                    Id = entity.Id,
                    FinalDate = entity.FinalDate,
                    CreatedDate = entity.CreatedDate,
                    state = entity.state,
                    price = entity.price,
                    productId = entity.productId,
                    quantity = entity.quantity,
                    SaleId = entity.SaleId,
                };
                return be;
            }
            return null;
        }
        #endregion

        #region Entity
        public SaleDetail CreateEntity(SaleDetailBE be)
        {
            SaleDetail entity;
            if (be != null)
            {
                entity = new SaleDetail()
                {
                    Id = be.Id,
                    FinalDate = be.FinalDate,
                    CreatedDate = be.CreatedDate,
                    state = be.state,
                    price = be.price,
                    productId = be.productId,
                    quantity = be.quantity,
                    SaleId = be.SaleId,
                };

                return entity;
            }
            return null;
        }

        #endregion
    }
}
