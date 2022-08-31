using DataModel.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataModel.Repositories.IRepository
{
    public interface IPaymentTypeRepository
    {
        List<PaymentType> GetAll(int state, int page, int top, string orderBy, string ascending, string name, ref int count);
        PaymentType GetById(string id);
        String Create(PaymentType paymentType);
        String Update(string id, PaymentType paymentType);
        String Delete(string id);
    }
}
