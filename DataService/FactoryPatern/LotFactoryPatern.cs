using BusnessEntities.BE;
using DataModel.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataService.FactoryPatern
{
    public class LotFactoryPatern
    {
        private static LotFactoryPatern _factory;
        public static LotFactoryPatern GetInstance()
        {
            if (_factory == null)
                _factory = new LotFactoryPatern();
            return _factory;
        }

        #region Business
        public LotBE CreateBusiness(Lot entity)
        {
            LotBE be;
            if (entity != null)
            {
                be = new LotBE()
                {
                    Id = entity.Id,
                    FinalDate = entity.FinalDate,
                    CreatedDate = entity.CreatedDate,
                    state = entity.state,
                    LotCode = entity.LotCode,
                    ExpiredDate = entity.ExpiredDate,
                    ProductId = entity.ProductId,
                };
                return be;
            }
            return null;
        }
        #endregion

        #region Entity
        public Lot CreateEntity(LotBE be)
        {
            Lot entity;
            if (be != null)
            {
                entity = new Lot()
                {
                    Id = be.Id,
                    FinalDate = be.FinalDate,
                    CreatedDate = be.CreatedDate,
                    state = be.state,
                    LotCode = be.LotCode,
                    ExpiredDate = be.ExpiredDate,
                    ProductId = be.ProductId
                };

                return entity;
            }
            return null;
        }

        #endregion
    }
}
