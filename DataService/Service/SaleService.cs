using BusnessEntities.BE;
using DataModel.Repositories.IRepository;
using DataService.FactoryPatern;
using DataService.Iservice;
using Resolver.Enums;
using Resolver.HelperError.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
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
        public List<PaymentTypeBE> GetAllPaymentType(int state)
        {
            try
            {
                var entities = _repo.GetAllPaymentType(state);

                List<PaymentTypeBE> be = new List<PaymentTypeBE>();

                if (entities.Count > 0)
                {
                    foreach (var item in entities)
                    {
                        be.Add(PaymentTypeFactory.GetInstance().CreateBusiness(item));
                    }
                }
                return be;
            }
            catch (Exception ex)
            {
                throw HandlerExceptions.GetInstance().RunCustomExceptions(ex);
            }
        }

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

        public string RemoveNoneSale(string id, string accountId, DeleteSaleEnum enumtype)
        {
            try
            {
                var entities = _repo.RemoveNoneSale(id, accountId, enumtype);
                return entities;
            }
            catch (Exception ex)
            {
                throw HandlerExceptions.GetInstance().RunCustomExceptions(ex);
            }
        }

        public string Update(string id, SaleBE sale)
        {
            try
            {
                var result = SaleFactory.GetInstance().CreateEntity(sale);
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
