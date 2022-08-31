using DataModel.Context;
using DataModel.Entities;
using DataModel.Repositories.IRepository;
using Resolver.Enums;
using Resolver.HelperError.Handlers;
using Resolver.HelperError.IExceptions;
using Resolver.QueryableExtensions;
using System;
using System.Collections.Generic;
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
                if (product.PurchasePrice > 0)
                    throw new ApiBusinessException("6000", "Debe ingresar el precio de compra del producto", System.Net.HttpStatusCode.NotFound, "Http");
                if (product.SalePrice > 0)
                    throw new ApiBusinessException("6000", "Debe ingresar el precio de venta", System.Net.HttpStatusCode.NotFound, "Http");

                product.Id = Guid.NewGuid().ToString();
                product.CreatedDate = DateTime.Now;
                product.FinalDate = null;
                product.state = (Int32)StateEnum.Activeted;

                _context.Add(product);
                _context.SaveChanges();
                return "La forma de pago fue guardado con exito";
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
                var entities = _context.Products.Where(u => u.state == state && (u.ProductName == name || string.IsNullOrEmpty(name)));
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
                entity.ExpirationDate = product.ExpirationDate;
                entity.ProductCode = product.ProductCode;

                _context.SaveChanges();

                return "El producto fue modificado con exito!";
            }
            catch (Exception ex)
            {
                throw HandlerExceptions.GetInstance().RunCustomExceptions(ex);
            }
        }
    }
}
