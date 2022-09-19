using BusnessEntities.BE;
using BusnessEntities.Dtos;
using DataModel.Repositories.IRepository;
using DataService.FactoryPatern;
using DataService.Iservice;
using Resolver.HelperError.Handlers;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataService.Service
{
    public class SaleDetailService : ISaleDetailService
    {
        private readonly ISaleDetailRepoository _repo;
        public SaleDetailService(ISaleDetailRepoository repo)
        {
            _repo = repo;
        }
        public string Create(SaleDetailBE saleDetail)
        {
            try
            {
                var result = SaleDetailFactory.GetInstance().CreateEntity(saleDetail);
                var entity = _repo.Create(result);
                return entity;
            }
            catch (Exception ex)
            {
                throw HandlerExceptions.GetInstance().RunCustomExceptions(ex);
            }
        }
        public string Delete(string id) => throw new NotImplementedException();
        public List<SaleDetailBE> GetAll(int state, int page, int top, string orderBy, string ascending, string name, ref int count) => throw new NotImplementedException();
        public SaleDetailBE GetById(string id) => throw new NotImplementedException();
        public List<SaleDetailDto> SearchAllDetailByCode(string saleCode)
        {
            try
            {
                var entities = _repo.SearchAllDetailByCode(saleCode);
                List<SaleDetailDto> be = new List<SaleDetailDto>();

                if (entities.Count > 0)
                {
                    foreach (var item in entities)
                    {
                        be.Add(new SaleDetailDto()
                        {
                            SaleId = item.SaleId,
                            Id = item.Id,
                            SalePrice = item.price,
                            productId = item.productId,
                            ProductName = item.Product.ProductName,
                            quantity = item.quantity,
                            ProductCode = item.Product.ProductCode
                        });
                    }
                }
                return be;
            }
            catch (Exception ex)
            {
                throw HandlerExceptions.GetInstance().RunCustomExceptions(ex);
            }
        }
        public string Update(string id, SaleDetailBE saleDetail) => throw new NotImplementedException();
    }
}
