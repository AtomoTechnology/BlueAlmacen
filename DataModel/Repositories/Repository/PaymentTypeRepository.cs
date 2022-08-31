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
    public class PaymentTypeRepository: IPaymentTypeRepository
    {
        private readonly DbGestionStockContext _context;
        public PaymentTypeRepository(DbGestionStockContext context)
        {
            _context = context;
        }
        public string Create(PaymentType paymentType)
        {
            try
            {
                if (paymentType == null)
                    throw new ApiBusinessException("4000", "falta datos forma de pago  en los campos obligatorios", System.Net.HttpStatusCode.NotFound, "Http");
                if (String.IsNullOrEmpty(paymentType.PaymentName))
                    throw new ApiBusinessException("4000", "Debe ingresar el nombre de la forma de pago", System.Net.HttpStatusCode.NotFound, "Http");

                paymentType.Id = Guid.NewGuid().ToString();
                paymentType.CreatedDate = DateTime.Now;
                paymentType.FinalDate = null;
                paymentType.state = (Int32)StateEnum.Activeted;

                _context.Add(paymentType);
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
                var entity = _context.Roles.SingleOrDefault(u => u.Id == id && u.FinalDate == null);
                if (entity == null)
                    throw new ApiBusinessException("3000", "NO existe esa forma de pago", System.Net.HttpStatusCode.NotFound, "Http");

                entity.FinalDate = DateTime.Now;
                entity.state = (Int32)StateEnum.Deleted;

                _context.SaveChanges();
                return "La forma de pago fue dado de baja con exito!";
            }
            catch (Exception ex)
            {
                throw HandlerExceptions.GetInstance().RunCustomExceptions(ex);
            }
        }

        public List<PaymentType> GetAll(int state, int page, int top, string orderBy, string ascending, string name, ref int count)
        {
            try
            {
                var entities = _context.PaymentTypes.Where(u => u.state == state && (u.PaymentName == name || string.IsNullOrEmpty(name)));
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

        public PaymentType GetById(string id)
        {
            try
            {
                var result = _context.PaymentTypes.SingleOrDefault(u => u.Id == id && u.state == (Int32)StateEnum.Activeted);
                return result;
            }
            catch (Exception ex)
            {
                throw HandlerExceptions.GetInstance().RunCustomExceptions(ex);
            }
        }

        public string Update(string id, PaymentType paymentType)
        {
            try
            {
                var entity = _context.PaymentTypes.Find(id);
                if (entity == null)
                    throw new ApiBusinessException("3000", "NO existe esa forma de pago", System.Net.HttpStatusCode.NotFound, "Http");

                entity.Description = paymentType.Description;
                entity.PaymentName = paymentType.PaymentName;

                _context.SaveChanges();

                return "La forma de pago fue modificado con exito!";
            }
            catch (Exception ex)
            {
                throw HandlerExceptions.GetInstance().RunCustomExceptions(ex);
            }
        }
    }
}
