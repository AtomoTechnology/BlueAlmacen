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
    public class RoleRepository : IRoleRepository
    {
        private readonly DbGestionStockContext _context;
        public RoleRepository(DbGestionStockContext context)
        {
            _context = context;
        }
        public string Create(Role role)
        {
            try
            {
                if (role == null)
                    throw new ApiBusinessException("3000", "falta datos roles en los campos obligatorios", System.Net.HttpStatusCode.NotFound, "Http");
                if (String.IsNullOrEmpty(role.RoleName))
                    throw new ApiBusinessException("3000", "Debe ingresar el nombre del rol", System.Net.HttpStatusCode.NotFound, "Http");

                role.Id = Guid.NewGuid().ToString();
                role.CreatedDate = DateTime.Now;
                role.FinalDate = null;
                role.state = (Int32)StateEnum.Activeted;

                _context.Add(role);
                _context.SaveChanges();
                return "El rol fue guardaddo con exito";
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
                    throw new ApiBusinessException("3000", "NO existe ese rol", System.Net.HttpStatusCode.NotFound, "Http");
                                
                entity.FinalDate = DateTime.Now;
                entity.state = (Int32)StateEnum.Deleted;

                _context.SaveChanges();
                return "El rol fue dado de baja con exito!";
            }
            catch (Exception ex)
            {
                throw HandlerExceptions.GetInstance().RunCustomExceptions(ex);
            }
        }

        public List<Role> GetAll(int state, int page, int top, string orderBy, string ascending, string name, ref int count)
        {
            try
            {
                var entities = _context.Roles.Where(u => u.state == state && ( u.RoleName == name || string.IsNullOrEmpty(name)));
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

        public Role GetById(string id)
        {
            try
            {
                var result = _context.Roles.SingleOrDefault(u => u.Id == id && u.state == (Int32)StateEnum.Activeted);
                return result;
            }
            catch (Exception ex)
            {
                throw HandlerExceptions.GetInstance().RunCustomExceptions(ex);
            }
        }

        public string Update(string id, Role role)
        {
            try
            {
                var entity = _context.Roles.Find(id);
                if (entity == null)
                    throw new ApiBusinessException("3000", "NO existe ese usuario", System.Net.HttpStatusCode.NotFound, "Http");

                entity.Description = role.Description;
                entity.RoleName = role.RoleName;

                _context.SaveChanges();

                return "El rol fue modificado con exito!";
            }
            catch (Exception ex)
            {
                throw HandlerExceptions.GetInstance().RunCustomExceptions(ex);
            }
        }
    }
}
