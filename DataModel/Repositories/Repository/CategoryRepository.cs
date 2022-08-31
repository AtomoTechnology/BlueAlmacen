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

namespace DataModel.Repositories.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly DbGestionStockContext _context;
        public CategoryRepository(DbGestionStockContext context)
        {
            _context = context;
        }
        public string Create(Category category)
        {
            try
            {
                if (category == null)
                    throw new ApiBusinessException("5000", "falta datos de categoria en los campos obligatorios", System.Net.HttpStatusCode.NotFound, "Http");
                if (String.IsNullOrEmpty(category.CategoryName))
                    throw new ApiBusinessException("5000", "Debe ingresar el nombre de la categoria", System.Net.HttpStatusCode.NotFound, "Http");

                category.Id = Guid.NewGuid().ToString();
                category.CreatedDate = DateTime.Now;
                category.FinalDate = null;
                category.state = (Int32)StateEnum.Activeted;

                _context.Add(category);
                _context.SaveChanges();
                return "La categoria fue guardada con exito";
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
                var entity = _context.Categories.SingleOrDefault(u => u.Id == id && u.FinalDate == null);
                if (entity == null)
                    throw new ApiBusinessException("5000", "NO existe esa categoria", System.Net.HttpStatusCode.NotFound, "Http");

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
        public List<Category> GetAll(int state, int page, int top, string orderBy, string ascending, string name, ref int count)
        {
            try
            {
                var entities = _context.Categories.Where(u => u.state == state && (u.CategoryName == name || string.IsNullOrEmpty(name)));
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
        public Category GetById(string id)
        {
            try
            {
                var result = _context.Categories.SingleOrDefault(u => u.Id == id && u.state == (Int32)StateEnum.Activeted);
                return result;
            }
            catch (Exception ex)
            {
                throw HandlerExceptions.GetInstance().RunCustomExceptions(ex);
            }
        }
        public string Update(string id, Category category)
        {
            try
            {
                var entity = _context.Categories.Find(id);
                if (entity == null)
                    throw new ApiBusinessException("3000", "NO existe esa categoria", System.Net.HttpStatusCode.NotFound, "Http");

                entity.Description = category.Description;
                entity.CategoryName = category.CategoryName;

                _context.SaveChanges();

                return "La categoria fue modificada con exito!";
            }
            catch (Exception ex)
            {
                throw HandlerExceptions.GetInstance().RunCustomExceptions(ex);
            }
        }
    }
}
