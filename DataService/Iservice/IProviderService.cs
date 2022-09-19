using BusnessEntities.BE;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataService.Iservice
{
    public interface IProviderService
    {
        List<ProviderBE> GetAll(int state, int page, int top, string orderBy, string ascending, string name, ref int count);
        ProviderBE GetById(string id);
        String Create(ProviderBE provider);
        String Update(string id, ProviderBE provider);
        String Delete(string id);
    }
}
