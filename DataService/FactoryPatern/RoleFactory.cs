using BusnessEntities.BE;
using DataModel.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataService.FactoryPatern
{
    public class RoleFactory
    {
        private static RoleFactory _factory;
        public static RoleFactory GetInstance()
        {
            if (_factory == null)
                _factory = new RoleFactory();
            return _factory;
        }

        #region Business
        public RoleBE CreateBusiness(Role entity)
        {
            RoleBE be;
            if (entity != null)
            {
                be = new RoleBE()
                {
                    RoleName = entity.RoleName,
                    Id = entity.Id,
                    FinalDate = entity.FinalDate,
                    Description = entity.Description,
                    CreatedDate = entity.CreatedDate,
                    state = entity.state
                };

                return be;
            }
            return null;
        }
        #endregion

        #region Entity
        public Role CreateEntity(RoleBE be)
        {
            Role entity;
            if (be != null)
            {
                entity = new Role()
                {
                    CreatedDate = be.CreatedDate,
                    Description = be.Description,
                    FinalDate = be.FinalDate,
                    Id = be.Id,
                    RoleName = be.RoleName,
                    state = be.state
                };

                return entity;
            }
            return null;
        }

        #endregion
    }
}
