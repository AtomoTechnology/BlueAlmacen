using DataModel.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataModel.Repositories.IRepository
{
    public interface IIncreasePriceAfterTwelveRepository
    {
        List<IncreasePriceAfterTwelve> GetAll(int state, int page, int top, string orderBy, string ascending, DateTime hourFrom, DateTime hourTo, string BusinessId, ref int count);
        IncreasePriceAfterTwelve GetById(string id);
        String Create(IncreasePriceAfterTwelve incr);
        String Update(string id, IncreasePriceAfterTwelve incr);
        String Delete(string id);
    }
}
