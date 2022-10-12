using BusnessEntities.BE;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataService.Iservice
{
    public interface IIncreasePriceAfterTwelveService
    {
        List<IncreasePriceAfterTwelveBE> GetAll(int state, int page, int top, string orderBy, string ascending, DateTime hourFrom, DateTime hourTo, string BusinessId, ref int count);
        IncreasePriceAfterTwelveBE GetById(string id);
        String Create(IncreasePriceAfterTwelveBE incr);
        String Update(string id, IncreasePriceAfterTwelveBE incr);
        String Delete(string id);
    }
}
