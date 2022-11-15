using Dapper;
using DataModel.Context;
using DataModel.Entities;
using DataModel.Repositories.IRepository;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Resolver.Enums;
using Resolver.HelperError.Handlers;
using Resolver.HelperError.IExceptions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DataModel.Repositories.Repository
{
    public class SaleDetailRepoository : ISaleDetailRepoository
    {
        private readonly DbGestionStockContext _context;
        public SaleDetailRepoository(DbGestionStockContext context)
        {
            _context = context;
        }
        public IEnumerable<SaleDetailEntityDto> Create(SaleDetail saleDetail)
        {
            try
            {
                if (saleDetail == null)
                    throw new ApiBusinessException("3000", "No se pudo realizar la venta", System.Net.HttpStatusCode.NotFound, "Http");

                using (var db = new DbGestionStockContext())
                {
                    using (var ctx = db.Database.GetDbConnection())
                    {
                        ctx.Open();
                        try
                        {
                            saleDetail.Id = Guid.NewGuid().ToString();
                            var values = new
                            {
                                isfirst = 1,
                                saleId = saleDetail.SaleId,
                                saledetailId = saleDetail.Id,
                                AccountId = "",
                                PaymentTypeId = "",
                                Total = 0.0,
                                price = saleDetail.price,
                                productId = saleDetail.productId,
                                quantity = saleDetail.quantity
                            };

                            IEnumerable<SaleDetailEntityDto> entity = ctx.Query<SaleDetailEntityDto>("[dbo].[Sp_Insert_Sale]", values, commandType: CommandType.StoredProcedure);
                            ctx.Close();
                            return entity;
                        }
                        catch (ApiBusinessException ex)
                        {
                            ctx.Close();
                            throw HandlerExceptions.GetInstance().RunCustomExceptions(ex);
                        }
                        catch (Exception ex)
                        {
                            ctx.Close();
                            throw HandlerExceptions.GetInstance().RunCustomExceptions(ex);
                        }
                    }
                }
                
            }
            catch (ApiBusinessException ex)
            {
                throw HandlerExceptions.GetInstance().RunCustomExceptions(ex);
            }
            catch (Exception ex)
            {
                throw HandlerExceptions.GetInstance().RunCustomExceptions(ex);
            }
        }
        public string Delete(string id) => throw new NotImplementedException();
        public List<SaleDetail> GetAll(int state, int page, int top, string orderBy, string ascending, string name, ref int count) => throw new NotImplementedException();
        public SaleDetail GetById(string id) => throw new NotImplementedException();
        public List<SaleDetail> SearchAllDetailByCode(string saleCode)
        {
            try
            {
                var entities = _context.SaleDetails.Include(P => P.Product).Include(p => p.Sale).Where(u => u.SaleId == saleCode);              
                return entities.ToList();
            }
            catch (Exception ex)
            {
                throw HandlerExceptions.GetInstance().RunCustomExceptions(ex);
            }
        }
        public string Update(string id, SaleDetail saleDetail) => throw new NotImplementedException();
    }
}
