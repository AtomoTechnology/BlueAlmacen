using BusnessEntities.BE;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataService.Iservice
{
    public interface ICategoryService
    {
        List<CategoryBE> GetAll(int state, int page, int top, string orderBy, string ascending, string name, ref int count);
        CategoryBE GetById(string id);
        String Create(CategoryBE be);
        String Update(string id, CategoryBE be);
        String Delete(string id);
    }
}
