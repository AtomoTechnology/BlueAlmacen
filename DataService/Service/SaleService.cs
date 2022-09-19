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
    public class SaleService : ISaleService
    {
        private readonly ISaleRepository _repo;
        public SaleService(ISaleRepository repo)
        {
            _repo = repo;
        }
        public string Create(SaleBE sale)
        {
            try
            {
                var result = SaleFactory.GetInstance().CreateEntity(sale);
                var entity = _repo.Create(result);
                return entity;
            }
            catch (Exception ex)
            {
                throw HandlerExceptions.GetInstance().RunCustomExceptions(ex);
            }
        }
        public string Delete(string id) => throw new NotImplementedException();
        public List<SaleBE> GetAll(int state, int page, int top, string orderBy, string ascending, string name, ref int count) => throw new NotImplementedException();
        public SaleBE GetById(string id)
        {
            try
            {
                var entities = _repo.GetById(id);
                return SaleFactory.GetInstance().CreateBusiness(entities);
            }
            catch (Exception ex)
            {
                throw HandlerExceptions.GetInstance().RunCustomExceptions(ex);
            }
        }
        public string Update(string id, SaleBE sale) => throw new NotImplementedException();
    }
}
