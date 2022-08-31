using BusnessEntities.BE;
using DataModel.Repositories.IRepository;
using DataService.FactoryPatern;
using DataService.Iservice;
using Resolver.HelperError.Handlers;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataService.Service
{
    public class BusnessService : IBusnessService
    {
        private readonly IBusinessRepository _repo;
        public BusnessService(IBusinessRepository repo)
        {
            _repo = repo;
        }
        public string Create(BusinessBE busness)
        {
            try
            {
                var result = BusinessFactory.GetInstance().CreateEntity(busness);
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
        public List<BusinessBE> GetAll(int state, int page, int top, string orderBy, string ascending, string name, ref int count)
        {
            try
            {
                var entities = _repo.GetAll(state, page, top, orderBy, ascending, name, ref count);
                List<BusinessBE> be = new List<BusinessBE>();
                if (entities.Count > 0)
                {
                    foreach (var item in entities)
                    {
                        be.Add(BusinessFactory.GetInstance().CreateBusiness(item));
                    }
                }
                return be;
            }
            catch (Exception ex)
            {
                throw HandlerExceptions.GetInstance().RunCustomExceptions(ex);
            }
        }
        public BusinessBE GetById(string id)
        {
            try
            {
                var entities = _repo.GetById(id);
                return BusinessFactory.GetInstance().CreateBusiness(entities);
            }
            catch (Exception ex)
            {
                throw HandlerExceptions.GetInstance().RunCustomExceptions(ex);
            }
        }
        public String Update(string id, BusinessBE busness)
        {
            try
            {
                var result = BusinessFactory.GetInstance().CreateEntity(busness);
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
