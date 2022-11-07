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
using System.Threading.Tasks;

namespace DataModel.Repositories.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly DbGestionStockContext _context;
        public UserRepository(DbGestionStockContext context)
        {
            _context = context;
        }
        public string Create(User user)
        {
            try
            {
                if (user == null)
                    throw new ApiBusinessException("1000", "falta datos usuario en los campos obligatorios", System.Net.HttpStatusCode.NotFound, "Http");
                if (String.IsNullOrEmpty(user.FirstName))
                    throw new ApiBusinessException("1000", "Debe ingresar el nombre del usuario", System.Net.HttpStatusCode.NotFound, "Http");
                if (String.IsNullOrEmpty(user.LastName))
                    throw new ApiBusinessException("1000", "Debe ingresar el apellido del usuario", System.Net.HttpStatusCode.NotFound, "Http");
                if (user.Accounts.Count == 0)
                    throw new ApiBusinessException("1000", "falta datos de login del usuario", System.Net.HttpStatusCode.NotFound, "Http");
                if (String.IsNullOrEmpty(user.Accounts[0].UserName))
                    throw new ApiBusinessException("1000", "Debe ingresar el nombre usuario", System.Net.HttpStatusCode.NotFound, "Http");
                if (String.IsNullOrEmpty(user.Accounts[0].UserPass))
                    throw new ApiBusinessException("1000", "Debe ingresar la contraseña usuario", System.Net.HttpStatusCode.NotFound, "Http");
                var isAccountExist = _context.Accounts.Where(u => u.UserName == user.Accounts[0].UserName).ToList();
                if (isAccountExist.Any()) 
                    throw new ApiBusinessException("1000", "Ya existe un usuario con ese nombre", System.Net.HttpStatusCode.NotFound, "Http");

                user.Id = Guid.NewGuid().ToString();
                user.CreatedDate = DateTime.Now;
                user.state = (Int32)StateEnum.Activeted;

                foreach (var item in user.Accounts)
                {
                    item.UserId = user.Id;
                    item.Id = Guid.NewGuid().ToString();
                    item.CreatedDate = DateTime.Now;
                    item.state = (Int32)StateEnum.Activeted;
                }

                _context.Add(user);
                _context.SaveChanges();
               return "EL usuario fue creado con existo.";
            }
            catch (Exception ex)
            {
                throw HandlerExceptions.GetInstance().RunCustomExceptions(ex);
            }
        }

        public bool Delete(string id)
        {
            try
            {
                var entity = _context.Users.Find(id);
                if (entity == null)
                    throw new ApiBusinessException("1000", "NO existe ese usuario", System.Net.HttpStatusCode.NotFound, "Http");

                foreach (var item in entity.Accounts)
                {
                    item.FinalDate = DateTime.Now;
                    item.state = (Int32)StateEnum.Deleted;
                }
                entity.FinalDate = DateTime.Now;
                entity.state = (Int32)StateEnum.Deleted;

                //_context.Add(entity);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw HandlerExceptions.GetInstance().RunCustomExceptions(ex);
            }
        }

        public List<User> GetAll(int state, int page, int top, string orderBy, string ascending, ref int count)
        {
            try
            {
                var entities = _context.Users.Where(u => u.state == state);
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

        public User GetById(string id)
        {
            try
            {
                var result = _context.Users.SingleOrDefault(u => u.Id == id && u.state == (Int32)StateEnum.Activeted);
                return result;
            }
            catch (Exception ex)
            {
                throw HandlerExceptions.GetInstance().RunCustomExceptions(ex);
            }
        }

        public string Update(string id, User user)
        {
            try
            {
                var entity = _context.Users.Find(id);
                if (entity == null)
                    throw new ApiBusinessException("1000", "NO existe ese usuario", System.Net.HttpStatusCode.NotFound, "Http");

                entity.Address = user.Address;
                entity.Phone = user.Phone;
                entity.FirstName = user.FirstName;
                entity.LastName = user.LastName;
                entity.Email = user.Email;

                _context.SaveChanges();

                return "El usuario fue modificado con exito" ;
            }
            catch (Exception ex)
            {
                throw HandlerExceptions.GetInstance().RunCustomExceptions(ex);
            }
        }
    }
}
