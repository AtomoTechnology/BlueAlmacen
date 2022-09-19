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
    public class SaleRepository : ISaleRepository
    {
        private readonly DbGestionStockContext _context;
        public SaleRepository(DbGestionStockContext context)
        {
            _context = context;
        }
        public string Create(Sale sale)
        {
            try
            {
                if (sale == null)
                    throw new ApiBusinessException("3000", "No se pudo realizar la venta", System.Net.HttpStatusCode.NotFound, "Http");



                sale.Id = Guid.NewGuid().ToString();
                sale.CreatedDate = DateTime.Now;
                sale.FinalDate = null;
                sale.state = (Int32)SaleEnum.PayActived;

                foreach (var item in sale.SaleDetail)
                {
                    item.Id = Guid.NewGuid().ToString();
                    item.SaleId = sale.Id;
                    item.CreatedDate = DateTime.Now;
                    item.FinalDate = null;
                    item.state = (Int32)SaleEnum.PayActived;

                    var entity = _context.Products.Find(item.productId);
                    entity.Stock--;
                }
               
                _context.Add(sale);
                _context.SaveChanges();
                return sale.Id;
            }
            catch (Exception ex)
            {
                throw HandlerExceptions.GetInstance().RunCustomExceptions(ex);
            }
        }
        public string Delete(string id) => throw new NotImplementedException();
        public List<Sale> GetAll(int state, int page, int top, string orderBy, string ascending, string name, ref int count) => throw new NotImplementedException();
        public Sale GetById(string id)
        {
            try
            {
                var result = _context.Sale.Include(u => u.SaleDetail).SingleOrDefault(u => u.Id == id && u.state == (Int32)StateEnum.Activeted && u.FinalDate == null);
                return result;
            }
            catch (Exception ex)
            {
                throw HandlerExceptions.GetInstance().RunCustomExceptions(ex);
            }
        }
        public string Update(string id, Sale sale)
        {
            try
            {
                var entity = _context.Sale.Find(id);
                if (entity == null)
                    throw new ApiBusinessException("3000", "NO existe ese proveedor", System.Net.HttpStatusCode.NotFound, "Http");
               
                entity.PaymentTypeId = sale.PaymentTypeId;
                entity.Total = sale.Total;
                entity.finalizeSale = sale.finalizeSale;
                entity.FinalDate = DateTime.Now;
                entity.state = (Int32)SaleEnum.PayFinished;

                _context.SaveChanges();

                return "La venta fue realizado con exito!";
            }
            catch (Exception ex)
            {
                throw HandlerExceptions.GetInstance().RunCustomExceptions(ex);
            }
        }
    }
}
