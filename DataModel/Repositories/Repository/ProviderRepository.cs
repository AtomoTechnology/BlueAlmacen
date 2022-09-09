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
    public class ProviderRepository : IProviderRepository
    {
        private readonly DbGestionStockContext _context;
        public ProviderRepository(DbGestionStockContext context)
        {
            _context = context;
        }
        public string Create(Provider provider)
        {
            try
            {
                if (provider == null)
                    throw new ApiBusinessException("3000", "falta datos proveedores en los campos obligatorios", System.Net.HttpStatusCode.NotFound, "Http");
                if (String.IsNullOrEmpty(provider.Name))
                    throw new ApiBusinessException("3000", "Debe ingresar el nombre del proveedor", System.Net.HttpStatusCode.NotFound, "Http");

                provider.Id = Guid.NewGuid().ToString();
                provider.CreatedDate = DateTime.Now;
                provider.FinalDate = null;
                provider.state = (Int32)StateEnum.Activeted;

                _context.Add(provider);
                _context.SaveChanges();
                return "El proveedor fue guardaddo con exito";
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
                var entity = _context.Providers.SingleOrDefault(u => u.Id == id && u.FinalDate == null && u.state == (Int32)StateEnum.Activeted);
                if (entity == null)
                    throw new ApiBusinessException("3000", "NO existe ese proveedor", System.Net.HttpStatusCode.NotFound, "Http");

                entity.FinalDate = DateTime.Now;
                entity.state = (Int32)StateEnum.Deleted;

                _context.SaveChanges();
                return "El proveedor fue dado de baja con exito!";
            }
            catch (Exception ex)
            {
                throw HandlerExceptions.GetInstance().RunCustomExceptions(ex);
            }
        }
        public List<Provider> GetAll(int state, int page, int top, string orderBy, string ascending, string name, ref int count)
        {
            try
            {
                var entities = _context.Providers.Where(u => u.state == state && (u.Name == name || string.IsNullOrEmpty(name)));
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
        public Provider GetById(string id)
        {
            try
            {
                var result = _context.Providers.SingleOrDefault(u => u.Id == id && u.state == (Int32)StateEnum.Activeted && u.FinalDate == null);
                return result;
            }
            catch (Exception ex)
            {
                throw HandlerExceptions.GetInstance().RunCustomExceptions(ex);
            }
        }
        public string Update(string id, Provider provider)
        {
            try
            {
                var entity = _context.Providers.Find(id);
                if (entity == null)
                    throw new ApiBusinessException("3000", "NO existe ese proveedor", System.Net.HttpStatusCode.NotFound, "Http");

                entity.Name = provider.Name;
                entity.Address = provider.Address;
                entity.Cuit_Cuil = provider.Cuit_Cuil;
                entity.Phone = provider.Phone;

                _context.SaveChanges();

                return "El provider fue modificado con exito!";
            }
            catch (Exception ex)
            {
                throw HandlerExceptions.GetInstance().RunCustomExceptions(ex);
            }
        }
    }
}
