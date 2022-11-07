using BusnessEntities.BE;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataService.Iservice
{
    public interface IUserService
    {
        List<UserBE> GetAll(int state, int page, int top, string orderBy, string ascending, string name, ref int count);
        UserBE GetById(string id);
        String Create(UserBE user);
        String Update(string id, UserBE user);
        Boolean Delete(string id);
    }
}
