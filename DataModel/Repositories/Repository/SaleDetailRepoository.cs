using DataModel.Context;
using DataModel.Entities;
using DataModel.Repositories.IRepository;
using Microsoft.EntityFrameworkCore;
using Resolver.Enums;
using Resolver.HelperError.Handlers;
using Resolver.HelperError.IExceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataModel.Repositories.Repository
{
    public class SaleDetailRepoository : ISaleDetailRepoository
    {
        private readonly DbGestionStockContext _context;
        public SaleDetailRepoository(DbGestionStockContext context)
        {
            _context = context;
        }
        public string Create(SaleDetail saleDetail)
        {
            try
            {
                if (saleDetail == null)
                    throw new ApiBusinessException("3000", "No se pudo realizar la venta", System.Net.HttpStatusCode.NotFound, "Http");

                saleDetail.Id = Guid.NewGuid().ToString();
                saleDetail.CreatedDate = DateTime.Now;
                saleDetail.FinalDate = null;
                saleDetail.state = (Int32)SaleEnum.PayActived;

                var entity = _context.Products.Find(saleDetail.productId);
                entity.Stock--;

                _context.Add(saleDetail);
                _context.SaveChanges();
                return saleDetail.SaleId;
            }
            catch (Exception ex)
            {
                throw HandlerExceptions.GetInstance().RunCustomExceptions(ex);
            }
        }
        public string Delete(string id) => throw new NotImplementedException();
        public List<SaleDetail> GetAll(int state, int page, int top, string orderBy, string ascending, string name, ref int count) => throw new NotImplementedException();
        public SaleDetail GetById(string id) => throw new NotImplementedException();
        public List<SaleDetail> SearchAllDetailByCode(string saleCode)
        {
            try
            {
                var entities = _context.SaleDetails.Include(P => P.Product).Include(p => p.Sale).Where(u => u.SaleId == saleCode);              
                return entities.ToList();
            }
            catch (Exception ex)
            {
                throw HandlerExceptions.GetInstance().RunCustomExceptions(ex);
            }
        }
        public string Update(string id, SaleDetail saleDetail) => throw new NotImplementedException();
    }
}
