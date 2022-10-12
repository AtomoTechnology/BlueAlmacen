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
    public class IncreasePriceAfterTwelveService : IIncreasePriceAfterTwelveService
    {
        private readonly IIncreasePriceAfterTwelveRepository _repo;
        public IncreasePriceAfterTwelveService(IIncreasePriceAfterTwelveRepository repo)
        {
            _repo = repo;
        }
        public string Create(IncreasePriceAfterTwelveBE incr)
        {
            try
            {
                var result = IncreasePriceAfterTwelveFactory.GetInstance().CreateEntity(incr);
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
        public List<IncreasePriceAfterTwelveBE> GetAll(int state, int page, int top, string orderBy, string ascending, DateTime hourFrom, DateTime hourTo, string BusinessId, ref int count)
        {
            try
            {
                var entities = _repo.GetAll(state, page, top, orderBy, ascending, hourFrom, hourTo, BusinessId, ref count);
                List<IncreasePriceAfterTwelveBE> be = new List<IncreasePriceAfterTwelveBE>();

                if (entities.Count > 0)
                {
                    foreach (var item in entities)
                    {
                        be.Add(IncreasePriceAfterTwelveFactory.GetInstance().CreateBusiness(item));
                    }
                }
                return be;
            }
            catch (Exception ex)
            {
                throw HandlerExceptions.GetInstance().RunCustomExceptions(ex);
            }
        }
        public IncreasePriceAfterTwelveBE GetById(string id)
        {
            try
            {
                var entities = _repo.GetById(id);
                return IncreasePriceAfterTwelveFactory.GetInstance().CreateBusiness(entities);
            }
            catch (Exception ex)
            {
                throw HandlerExceptions.GetInstance().RunCustomExceptions(ex);
            }
        }
        public string Update(string id, IncreasePriceAfterTwelveBE incr)
        {
            try
            {
                var result = IncreasePriceAfterTwelveFactory.GetInstance().CreateEntity(incr);
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
