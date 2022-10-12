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
                
                Int64 InvoiceCode = 0;
                var code = _context.Sales.ToList();

                if (code.Count > 0)
                    InvoiceCode = code.Max(u => u.InvoiceCode) + 1;
                else
                    InvoiceCode = 1;

                sale.Id = Guid.NewGuid().ToString();
                sale.CreatedDate = DateTime.Now;
                sale.FinalDate = null;
                sale.state = (Int32)SaleEnum.PayActived;
                sale.InvoiceCode = InvoiceCode;

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
        public List<PaymentType> GetAllPaymentType(int state)
        {
            try
            {
                var entities = _context.PaymentTypes.Where(u => u.state == state && u.FinalDate == null);  
                return entities.ToList();
            }
            catch (Exception ex)
            {
                throw HandlerExceptions.GetInstance().RunCustomExceptions(ex);
            }
        }

        public Sale GetById(string id)
        {
            try
            {
                var result = _context.Sales.Include(u => u.SaleDetail).SingleOrDefault(u => u.Id == id && u.state == (Int32)StateEnum.Activeted && u.FinalDate == null);
                return result;
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
                if (DeleteSaleEnum.Admin == enumtype)
                {
                    var detail = _context.SaleDetails.SingleOrDefault(u => u.Id == id);
                    if (detail == null)
                        throw new ApiBusinessException("3000", "NO hay venta para eliminar", System.Net.HttpStatusCode.NotFound, "Http");

                    var entitycontext = _context.Products.Find(detail.productId);
                    entitycontext.Stock++;

                    var history = new History()
                    {
                        Id = Guid.NewGuid().ToString(),
                        OptionId = detail.SaleId,
                        AccountId = accountId,
                        ModuleAction = "Modulo de venta de producto",
                        Action = "Eliminacion de venta por el admin",
                        CreatedDate = DateTime.Now,
                        TypeId = (Int32)HistoricEnum.Sale,
                        state = (Int32)StateEnum.Activeted
                    };

                    _context.Add(history);
                    _context.Remove(detail);
                }
                else
                {
                    var entity = _context.Sales.Include(u => u.SaleDetail).SingleOrDefault(u => u.Id == id && u.FinalDate == null && u.state == (Int32)StateEnum.Activeted);
                    if (entity == null)
                        throw new ApiBusinessException("3000", "NO hay venta para eliminar", System.Net.HttpStatusCode.NotFound, "Http");
                    foreach (var item in entity.SaleDetail)
                    {
                        var entitycontext = _context.Products.Find(item.productId);
                        entitycontext.Stock++;
                    }

                    var history = new History()
                    {
                        Id = Guid.NewGuid().ToString(),
                        OptionId = entity.Id,
                        AccountId = accountId,
                        ModuleAction = "Modulo de venta de producto",
                        Action = "Eliminacion de ventas por cerrar la pantalla de ventas",
                        CreatedDate = DateTime.Now,
                        TypeId = (Int32)HistoricEnum.Sale,
                        state = (Int32)StateEnum.Activeted
                    };
                    _context.Add(history);
                    _context.Remove(entity);
                }
                _context.SaveChanges();
                return "El lote fue dado de baja con exito!";
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
                var entity = _context.Sales.Find(id);
                if (entity == null)
                    throw new ApiBusinessException("3000", "No se pudo cerrar la venta", System.Net.HttpStatusCode.NotFound, "Http");
               
                entity.PaymentTypeId = sale.PaymentTypeId;
                entity.Total = sale.Total;
                entity.finalizeSale = sale.finalizeSale;
                entity.ModifiedDate = DateTime.Now;
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
