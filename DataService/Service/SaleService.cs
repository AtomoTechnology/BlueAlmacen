using AutoMapper;
using BusnessEntities.BE;
using BusnessEntities.Dtos;
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
        private readonly IMapper _maapper;
        public SaleService(ISaleRepository repo, IMapper maapper)
        {
            _repo = repo;
            _maapper = maapper;
        }
        public List<SaleDetailDto> Create(SaleBE sale)
        {
            try
            {
                var result = SaleFactory.GetInstance().CreateEntity(sale);
                var entity = _repo.Create(result).ToList();
                List<SaleDetailDto> dto = new List<SaleDetailDto>();
                if (entity.Count > 0)
                {
                    foreach (var item in entity)
                    {
                        dto.Add(new SaleDetailDto()
                        {
                            SaleId = item.SaleId,
                            Id = item.Id,
                            SalePrice = item.SalePrice,
                            productId = item.productId,
                            ProductName = item.ProductName,
                            quantity = item.quantity,
                            InvoiceCode = item.InvoiceCode,
                            ProductCode = item.ProductCode
                        });
                    }
                }
                return dto;
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

        public List<SearchSaleSPDTO> GetAllSaleHistoric(DateTime datefrom, DateTime dateto)
        {
            try
            {
                var entity = _repo.GetAllSaleHistoric(datefrom, dateto).ToList();
                List<SearchSaleSPDTO> dto = new List<SearchSaleSPDTO>();
                if (entity.Count > 0)
                {
                    foreach (var item in entity)
                    {
                        dto.Add(_maapper.Map<SearchSaleSPDTO>(entity));
                    }
                }
                return dto;
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
