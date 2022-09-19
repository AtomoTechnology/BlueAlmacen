using BusnessEntities.BE;
using DataModel.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataService.FactoryPatern
{
    public class CategoryFactory
    {
        private static CategoryFactory _factory;
        public static CategoryFactory GetInstance()
        {
            if (_factory == null)
                _factory = new CategoryFactory();
            return _factory;
        }

        #region Business
        public CategoryBE CreateBusiness(Category entity)
        {
            CategoryBE be;
            if (entity != null)
            {
                be = new CategoryBE()
                {
                    Id = entity.Id,
                    FinalDate = entity.FinalDate,
                    CreatedDate = entity.CreatedDate,
                    state = entity.state,
                    AccountId = entity.AccountId,
                    CategoryName = entity.CategoryName,
                    Description = entity.Description,
                };
                return be;
            }
            return null;
        }
        #endregion

        #region Entity
        public Category CreateEntity(CategoryBE be)
        {
            Category entity;
            if (be != null)
            {
                entity = new Category()
                {
                    Id = be.Id,
                    FinalDate = be.FinalDate,
                    CreatedDate = be.CreatedDate,
                    state = be.state,
                    AccountId = be.AccountId,
                    CategoryName = be.CategoryName,
                    Description = be.Description,
                };

                return entity;
            }
            return null;
        }

        #endregion
    }
}
