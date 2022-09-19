using BusnessEntities.BE;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataService.Iservice
{
    public interface ISaleService
    {
        List<SaleBE> GetAll(int state, int page, int top, string orderBy, string ascending, string name, ref int count);
        SaleBE GetById(string id);
        String Create(SaleBE sale);
        String Update(string id, SaleBE sale);
        String Delete(string id);
    }
}
