using BusnessEntities.BE;
using DataModel.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataService.FactoryPatern
{
    public class SaleFactory
    {
        private static SaleFactory _factory;
        public static SaleFactory GetInstance()
        {
            if (_factory == null)
                _factory = new SaleFactory();
            return _factory;
        }

        #region Business
        public SaleBE CreateBusiness(Sale entity)
        {
            SaleBE be;
            if (entity != null)
            {
                be = new SaleBE()
                {
                    Id = entity.Id,
                    FinalDate = entity.FinalDate,
                    CreatedDate = entity.CreatedDate,
                    state = entity.state,
                    AccountId = entity.AccountId,
                    finalizeSale = entity.finalizeSale,
                    PaymentTypeId = entity.PaymentTypeId,
                    Total = entity.Total,
                    InvoiceCode = entity.InvoiceCode
                };
                if (entity.SaleDetail != null)
                {
                    be.SaleDetail = new List<SaleDetailBE>();
                    foreach (SaleDetail detail in entity.SaleDetail)
                    {
                        be.SaleDetail.Add(SaleDetailFactory.GetInstance().CreateBusiness(detail));
                    }
                }
                return be;
            }
            return null;
        }
        #endregion

        #region Entity
        public Sale CreateEntity(SaleBE be)
        {
            Sale entity;
            if (be != null)
            {
                entity = new Sale()
                {
                    Id = be.Id,
                    FinalDate = be.FinalDate,
                    CreatedDate = be.CreatedDate,
                    state = be.state,
                    AccountId = be.AccountId,
                    finalizeSale = be.finalizeSale,
                    PaymentTypeId = be.PaymentTypeId,
                    Total = be.Total,
                    InvoiceCode= be.InvoiceCode
                };
                if (be.SaleDetail != null)
                {
                    entity.SaleDetail = new List<SaleDetail>();
                    foreach (SaleDetailBE detail in be.SaleDetail)
                    {
                        entity.SaleDetail.Add(SaleDetailFactory.GetInstance().CreateEntity(detail));
                    }
                }
                return entity;
            }
            return null;
        }

        #endregion
    }
}
