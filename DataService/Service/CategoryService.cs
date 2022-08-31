using BusnessEntities.BE;
using DataModel.Repositories.IRepository;
using DataService.FactoryPatern;
using DataService.Iservice;
using Resolver.HelperError.Handlers;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataService.Service
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _repo;
        public CategoryService(ICategoryRepository repo)
        {
            _repo = repo;
        }
        public string Create(CategoryBE be)
        {
            try
            {
                var result = CategoryFactory.GetInstance().CreateEntity(be);
                var entity = _repo.Create(result);
                return entity;
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
                var entity = _repo.Delete(id);
                return entity;
            }
            catch (Exception ex)
            {
                throw HandlerExceptions.GetInstance().RunCustomExceptions(ex);
            }
        }
        public List<CategoryBE> GetAll(int state, int page, int top, string orderBy, string ascending, string name, ref int count)
        {
            try
            {
                var entities = _repo.GetAll(state, page, top, orderBy, ascending, name, ref count);
                List<CategoryBE> be = new List<CategoryBE>();
                if (entities.Count > 0)
                {
                    foreach (var item in entities)
                    {
                        be.Add(CategoryFactory.GetInstance().CreateBusiness(item));
                    }
                }
                return be;
            }
            catch (Exception ex)
            {
                throw HandlerExceptions.GetInstance().RunCustomExceptions(ex);
            }
        }
        public CategoryBE GetById(string id)
        {
            try
            {
                var entities = _repo.GetById(id);
                return CategoryFactory.GetInstance().CreateBusiness(entities);
            }
            catch (Exception ex)
            {
                throw HandlerExceptions.GetInstance().RunCustomExceptions(ex);
            }
        }
        public string Update(string id, CategoryBE be)
        {
            try
            {
                var result = CategoryFactory.GetInstance().CreateEntity(be);
                var entities = _repo.Update(id, result);
                return entities;
            }
            catch (Exception ex)
            {
                throw HandlerExceptions.GetInstance().RunCustomExceptions(ex);
            }
        }
    }
}
