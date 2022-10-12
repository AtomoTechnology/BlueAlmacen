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
    public class LotRepository : ILotRepository
    {
        private readonly DbGestionStockContext _context;
        public LotRepository(DbGestionStockContext context)
        {
            _context = context;
        }
        public string Create(Lot entity)
        {
            try
            {
                if (entity == null)
                    throw new ApiBusinessException("3000", "falta datos del lote en los campos obligatorios", System.Net.HttpStatusCode.NotFound, "Http");
                if (String.IsNullOrEmpty(entity.LotCode))
                    throw new ApiBusinessException("3000", "Debe ingresar el numero del lote", System.Net.HttpStatusCode.NotFound, "Http");
                if (entity.ExpiredDate == DateTime.Now)
                    throw new ApiBusinessException("3000", "La fecha de vencimiento del lote no puede ser igual que hoy", System.Net.HttpStatusCode.NotFound, "Http");

                entity.Id = Guid.NewGuid().ToString();
                entity.CreatedDate = DateTime.Now;
                entity.FinalDate = null;
                entity.state = (Int32)StateEnum.Activeted;

                _context.Add(entity);
                _context.SaveChanges();
                return "El lote fue guardado con exito";
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
                var entity = _context.Lots.SingleOrDefault(u => u.Id == id && u.FinalDate == null && u.state == (Int32)StateEnum.Activeted);
                if (entity == null)
                    throw new ApiBusinessException("3000", "NO existe ese lote", System.Net.HttpStatusCode.NotFound, "Http");

                entity.FinalDate = DateTime.Now;
                entity.state = (Int32)StateEnum.Deleted;

                _context.SaveChanges();
                return "El lote fue dado de baja con exito!";
            }
            catch (Exception ex)
            {
                throw HandlerExceptions.GetInstance().RunCustomExceptions(ex);
            }
        }
        public List<Lot> GetAll(int state, int page, int top, string orderBy, string ascending, string LotCode, ref int count)
        {
            try
            {
                var entities = _context.Lots.Where(u => u.state == state && (u.LotCode == LotCode || string.IsNullOrEmpty(LotCode)));
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
        public Lot GetById(string id)
        {
            try
            {
                var result = _context.Lots.SingleOrDefault(u => u.Id == id && u.state == (Int32)StateEnum.Activeted);
                return result;
            }
            catch (Exception ex)
            {
                throw HandlerExceptions.GetInstance().RunCustomExceptions(ex);
            }
        }
        public string Update(string id, Lot entity)
        {
            try
            {
                var ent = _context.Lots.Find(id);
                if (entity == null)
                    throw new ApiBusinessException("3000", "NO existe ese lote", System.Net.HttpStatusCode.NotFound, "Http");

                ent.ExpiredDate = entity.ExpiredDate;
                ent.LotCode = entity.LotCode;

                _context.SaveChanges();

                return "El lote fue modificado con exito!";
            }
            catch (Exception ex)
            {
                throw HandlerExceptions.GetInstance().RunCustomExceptions(ex);
            }
        }
    }
}
