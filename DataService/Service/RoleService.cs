using BusnessEntities.BE;
using DataModel.Entities;
using DataModel.Repositories.IRepository;
using DataModel.Repositories.Repository;
using DataService.FactoryPatern;
using DataService.Iservice;
using Resolver.HelperError.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataService.Service
{
    public class RoleService: IRoleService
    {
        private readonly IRoleRepository _repo;
        public RoleService(IRoleRepository repo)
        {
            _repo = repo;
        }
        public string Create(RoleBE role)
        {
            try
            {
                var result = RoleFactory.GetInstance().CreateEntity(role);
                var entity = _repo.Create(result);
                return entity;
            }
            catch (Exception ex)
            {
                throw HandlerExceptions.GetInstance().RunCustomExceptions(ex);
            }
        }

        public String Delete(string id)
        {
            try
            {
                var entity = _repo.Delete(id);
                return entity;
            }
            catch (Exception ex)
            {
                throw HandlerExceptions.GetInstance().RunCustomExceptions(ex);
            }
        }

        public List<RoleBE> GetAll(int state, int page, int top, string orderBy, string ascending, string name, ref int count)
        {
            try
            {
                var entities = _repo.GetAll(state, page,top, orderBy, ascending, name, ref count);
                List<RoleBE> be = new List<RoleBE>();
                
                if (entities.Count > 0)
                {
                    foreach (var item in entities)
                    {
                        be.Add(RoleFactory.GetInstance().CreateBusiness(item));
                    }
                }
                return be;
            }
            catch (Exception ex)
            {
                throw HandlerExceptions.GetInstance().RunCustomExceptions(ex);
            }
        }

        public RoleBE GetById(string id)
        {
            try
            {
                var entities = _repo.GetById(id);
                return RoleFactory.GetInstance().CreateBusiness(entities);
            }
            catch (Exception ex)
            {
                throw HandlerExceptions.GetInstance().RunCustomExceptions(ex);
            }
        }

        public String Update(string id, RoleBE role)
        {
            try
            {
                var result = RoleFactory.GetInstance().CreateEntity(role);
                var entities = _repo.Update(id, result);
                return entities;
            }
            catch (Exception ex)
            {
                throw HandlerExceptions.GetInstance().RunCustomExceptions(ex);
            }
        }
    }
}
