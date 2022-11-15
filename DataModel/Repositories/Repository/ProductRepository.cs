using Dapper;
using DataModel.Context;
using DataModel.Entities;
using DataModel.Repositories.IRepository;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Resolver.Enums;
using Resolver.HelperError.Handlers;
using Resolver.HelperError.IExceptions;
using Resolver.QueryableExtensions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DataModel.Repositories.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly DbGestionStockContext _context;
        public ProductRepository(DbGestionStockContext context)
        {
            _context = context;
        }
        public string Create(Product product)
        {
            try
            {
                if (product == null)
                    throw new ApiBusinessException("6000", "falta datos del productoo  en los campos obligatorios", System.Net.HttpStatusCode.NotFound, "Http");
                if (String.IsNullOrEmpty(product.ProductName))
                    throw new ApiBusinessException("6000", "Debe ingresar el nombre del producto", System.Net.HttpStatusCode.NotFound, "Http");
                if (String.IsNullOrEmpty(product.ProductCode))
                    throw new ApiBusinessException("6000", "Debe ingresar el código del producto", System.Net.HttpStatusCode.NotFound, "Http");
                if (product.PurchasePrice <= 0)
                    throw new ApiBusinessException("6000", "Debe ingresar el precio de compra del producto", System.Net.HttpStatusCode.NotFound, "Http");
                if (product.SalePrice <= 0)
                    throw new ApiBusinessException("6000", "Debe ingresar el precio de venta", System.Net.HttpStatusCode.NotFound, "Http");

                product.Id = Guid.NewGuid().ToString();
                product.CreatedDate = DateTime.Now;
                product.FinalDate = null;
                product.state = (Int32)StateEnum.Activeted;

                foreach (var item in product.Lots)
                {
                    item.Id = Guid.NewGuid().ToString();
                    item.ProductId = product.Id;
                    item.CreatedDate = DateTime.Now;
                    item.FinalDate = null;
                    item.state = (Int32)StateEnum.Activeted;
                }

                _context.Add(product);
                _context.SaveChanges();
                return "El producto fue guardado con exito";
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
                var entity = _context.Products.SingleOrDefault(u => u.Id == id && u.FinalDate == null);
                if (entity == null)
                    throw new ApiBusinessException("3000", "NO existe ee producto", System.Net.HttpStatusCode.NotFound, "Http");

                entity.FinalDate = DateTime.Now;
                entity.state = (Int32)StateEnum.Deleted;

                _context.SaveChanges();
                return "El producto fue dado de baja con exito!";
            }
            catch (Exception ex)
            {
                throw HandlerExceptions.GetInstance().RunCustomExceptions(ex);
            }
        }
        public List<Product> GetAll(int state, int page, int top, string orderBy, string ascending, string name, ref int count)
        {
            try
            {
                var entities = _context.Products.Include(u => u.Lots).Where(u => (u.state == state && u.FinalDate == null) && (u.ProductName == name || string.IsNullOrEmpty(name)));
                count = entities.Count();
                var skipAmount = 0;
                if (page > 0)
                    skipAmount = top * (page - 1);

                entities = entities
               .OrderByPropertyOrField(orderBy, ascending)
               .Skip(skipAmount)
               .Take(top);

                return entities.ToList();
            }
            catch (Exception ex)
            {
                throw HandlerExceptions.GetInstance().RunCustomExceptions(ex);
            }
        }
        public Product GetById(string id)
        {
            try
            {
                var result = _context.Products.SingleOrDefault(u => u.Id == id && u.state == (Int32)StateEnum.Activeted);
                return result;
            }
            catch (Exception ex)
            {
                throw HandlerExceptions.GetInstance().RunCustomExceptions(ex);
            }
        }

        public Product SearchProducByCode(string codeRef, bool ischeckprice = false)
        {
            try
            {
                using (var db = new DbGestionStockContext())
                {
                    using (var ctx = db.Database.GetDbConnection())
                    {
                        try
                        {
                            ctx.Open();
                            var values = new
                            {
                                codeRef = codeRef
                            };
                            List<Product> entity = ctx.Query<Product>("[dbo].[Sp_Get_Product_CodRef]", values, commandType: CommandType.StoredProcedure).ToList();
                            if (entity.Any())
                            {
                                var result = entity.FirstOrDefault();                               
                                if (result.Stock == 0 && !ischeckprice)
                                    throw new ApiBusinessException("3000", "Productto sin stock", System.Net.HttpStatusCode.NotFound, "Http");
                                ctx.Close();
                                return result;
                            }
                            else
                                throw new ApiBusinessException("3000", "NO existe producto para ese codigo", System.Net.HttpStatusCode.NotFound, "Http"); ;
                        }
                        catch (ApiBusinessException ex)
                        {
                            ctx.Close();
                            throw HandlerExceptions.GetInstance().RunCustomExceptions(ex);
                        }
                        catch (Exception ex)
                        {
                            ctx.Close();
                            throw HandlerExceptions.GetInstance().RunCustomExceptions(ex);
                        }
                    }
                }
            }
            catch (ApiBusinessException ex)
            {
                throw HandlerExceptions.GetInstance().RunCustomExceptions(ex);
            }
            catch (Exception ex)
            {
                throw HandlerExceptions.GetInstance().RunCustomExceptions(ex);
            }
        }

        public string Update(string id, Product product)
        {
            try
            {
                var entity = _context.Products.Find(id);
                if (entity == null)
                    throw new ApiBusinessException("3000", "NO existe ese producto", System.Net.HttpStatusCode.NotFound, "Http");    
                
                entity.Description = product.Description;
                entity.ProductName = product.ProductName;
                entity.PurchasePrice = product.PurchasePrice;
                entity.SalePrice = product.SalePrice;
                entity.CategoryId = product.CategoryId;
                entity.ProviderId = product.ProviderId;
                entity.Stock = product.Stock;
                entity.ProductCode = product.ProductCode;

                var result = _context.Lots.SingleOrDefault(u => u.LotCode == product.Lots[0].LotCode && u.state == (Int32)StateEnum.Activeted);
                if (result == null)
                {
                    foreach (var item in product.Lots)
                    {
                        item.ProductId = id;
                        item.Id = Guid.NewGuid().ToString();
                        item.CreatedDate = DateTime.Now;
                        item.FinalDate = null;
                        item.state = (Int32)StateEnum.Activeted;

                        _context.Add(item);
                    }
                }
                _context.SaveChanges();

                return "El producto fue modificado con exito!";
            }
            catch (Exception ex)
            {
                throw HandlerExceptions.GetInstance().RunCustomExceptions(ex);
            }
        }

        public string UpdatePrices(string id, string accountId, decimal porcentsale, decimal porcentpurchase, UpdatePriceEnum priceenum, bool ispurchaseprice = false)
        {
            string productName = string.Empty;
            List<HistoryPrice> historicprice = null;
            try
            {
                if (UpdatePriceEnum.All == priceenum)
                {
                    var entityall = _context.Products.Where(u => u.state == (Int32)StateEnum.Activeted && u.FinalDate == null).ToList();
                    if (!entityall.Any())
                        throw new ApiBusinessException("3000", "No hay producto para actualizar", System.Net.HttpStatusCode.NotFound, "Http");
                    historicprice = new List<HistoryPrice>();
                    foreach (var item in entityall)
                    {
                        historicprice.Add(new HistoryPrice()
                        {
                            Id = Guid.NewGuid().ToString(),
                            ProductId = item.Id,
                            AccountId = accountId,
                            CreatedDate = DateTime.Now,
                            PricePurchase = ispurchaseprice == true ? item.PurchasePrice * (1 + (porcentpurchase / 100)) : item.PurchasePrice,
                            PriceSale = item.SalePrice * (1 + (porcentsale / 100)),
                            typeUpdate =(Int32)priceenum,
                            state = (Int32)StateEnum.Activeted,
                        });
                    }
                }
                else
                {
                    var entity = _context.Products.Find(id);
                    if (entity == null)
                        throw new ApiBusinessException("3000", "NO existe ese producto", System.Net.HttpStatusCode.NotFound, "Http");
                    
                    historicprice = new List<HistoryPrice>();


                    historicprice.Add(new HistoryPrice()
                    {
                        Id = Guid.NewGuid().ToString(),
                        ProductId = entity.Id,
                        AccountId = accountId,
                        CreatedDate = DateTime.Now,
                        PricePurchase = ispurchaseprice == true ? entity.PurchasePrice * (1 + (porcentpurchase / 100)) : entity.PurchasePrice,
                        PriceSale = entity.SalePrice * (1 + (porcentsale / 100)),
                        typeUpdate = (Int32)priceenum,
                        state = (Int32)StateEnum.Activeted,
                    });
                   
                    productName = entity.ProductName;
                }
                _context.AddRange(historicprice);
                _context.SaveChanges();
                var resp = (UpdatePriceEnum.All == priceenum || ispurchaseprice);
                var ms = "El precio para el producto " + "* " + productName + " *" + " se actualizó correctamente. \n Deseas seguir actualizando otro precio de producto?";
                return (resp ? "Los precios fueron actualizados con exitos!" : ms);
            }
            catch (Exception ex)
            {
                throw HandlerExceptions.GetInstance().RunCustomExceptions(ex);
            }
        }

        public bool SearchExpiredProductByLotCode(string lotCode)
        {
            try
            {
                var result = _context.Lots.SingleOrDefault(u => u.LotCode == lotCode && u.state == (Int32)StateEnum.Activeted);
                if (result == null)
                    return true;
                if (result.ExpiredDate < DateTime.Now)
                    throw new ApiBusinessException("3000", "Esta vencido el producto para ese lote", System.Net.HttpStatusCode.NotFound, "Http");
                return true;
            }
            catch (Exception ex)
            {
                throw HandlerExceptions.GetInstance().RunCustomExceptions(ex);
            }
        }
    }
}
