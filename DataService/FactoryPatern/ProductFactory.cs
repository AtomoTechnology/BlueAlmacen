using BusnessEntities.BE;
using DataModel.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataService.FactoryPatern
{
    public class ProductFactory
    {
        private static ProductFactory _factory;
        public static ProductFactory GetInstance()
        {
            if (_factory == null)
                _factory = new ProductFactory();
            return _factory;
        }

        #region Business
        public ProductBE CreateBusiness(Product entity)
        {
            ProductBE be;
            if (entity != null)
            {
                be = new ProductBE()
                {
                    Id = entity.Id,
                    FinalDate = entity.FinalDate,
                    CreatedDate = entity.CreatedDate,
                    state = entity.state,
                    ProductName = entity.ProductName,
                    CategoryId = entity.CategoryId,
                    AccountId = entity.AccountId,
                    ProviderId = entity.ProviderId,
                    ExpirationDate = entity.ExpirationDate,
                    ProductCode = entity.ProductCode,
                    Stock = entity.Stock,
                    PurchasePrice = entity.PurchasePrice,
                    SalePrice = entity.SalePrice,
                    Description = entity.Description,
                };
                return be;
            }
            return null;
        }
        #endregion

        #region Entity
        public Product CreateEntity(ProductBE be)
        {
            Product entity;
            if (be != null)
            {
                entity = new Product()
                {
                    Id = be.Id,
                    FinalDate = be.FinalDate,
                    CreatedDate = be.CreatedDate,
                    state = be.state,
                    ProductName = be.ProductName,
                    CategoryId = be.CategoryId,
                    AccountId = be.AccountId,
                    ExpirationDate = be.ExpirationDate,
                    ProductCode = be.ProductCode,
                    Stock = be.Stock,
                    ProviderId = be.ProviderId,
                    PurchasePrice = be.PurchasePrice,
                    SalePrice = be.SalePrice,
                    Description = be.Description,
                };

                return entity;
            }
            return null;
        }

        #endregion
    }
}
