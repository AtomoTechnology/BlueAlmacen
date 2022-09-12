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
    public class ProviderService : IProviderService
    {
        private readonly IProviderRepository _repo;
        public ProviderService(IProviderRepository repo)
        {
            _repo = repo;
        }
        public string Create(ProviderBE role)
        {
            try
            {
                var result = ProviderFactory.GetInstance().CreateEntity(role);
                var entity = _repo.Create(result);
                return entity;
            }
            catch (Exception ex)
            {
                throw HandlerExceptions.GetInstance().RunCustomExceptions(ex);
            }
        }
        public string Delete(string id)
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
        public List<ProviderBE> GetAll(int state, int page, int top, string orderBy, string ascending, string name, ref int count)
        {
            try
            {
                var entities = _repo.GetAll(state, page, top, orderBy, ascending, name, ref count);
                List<ProviderBE> be = new List<ProviderBE>();

                if (entities.Count > 0)
                {
                    foreach (var item in entities)
                    {
                        be.Add(ProviderFactory.GetInstance().CreateBusiness(item));
                    }
                }
                return be;
            }
            catch (Exception ex)
            {
                throw HandlerExceptions.GetInstance().RunCustomExceptions(ex);
            }
        }
        public ProviderBE GetById(string id)
        {
            try
            {
                var entities = _repo.GetById(id);
                return ProviderFactory.GetInstance().CreateBusiness(entities);
            }
            catch (Exception ex)
            {
                throw HandlerExceptions.GetInstance().RunCustomExceptions(ex);
            }
        }
        public string Update(string id, ProviderBE role)
        {
            try
            {
                var result = ProviderFactory.GetInstance().CreateEntity(role);
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
