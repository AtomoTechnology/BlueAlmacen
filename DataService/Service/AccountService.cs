﻿using BusnessEntities.BE;
using DataModel.Repositories.IRepository;
using DataService.FactoryPatern;
using DataService.Iservice;
using Resolver.HelperError.Handlers;
using Resolver.Security;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataService.Service
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _repo;
        public AccountService(IAccountRepository repo)
        {
            _repo = repo;
        }
        public string ChangePassword(AccountBE be) 
        {
            try
            {
                var entity = AccountFactory.GetInstance().CreateEntity(be);
                var result = _repo.ChangePassword(entity);
                return result;
            }
            catch (Exception ex)
            {
                throw HandlerExceptions.GetInstance().RunCustomExceptions(ex);
            }
        }
        public AccountBE Login(string username, string userpass) {
            try
            {
                var entity = _repo.Login(username, PassValidation.GetInstance().Encypt(userpass));
                return AccountFactory.GetInstance().CreateBusiness(entity);
            }
            catch (Exception ex)
            {
                throw HandlerExceptions.GetInstance().RunCustomExceptions(ex);
            }
        }
        public string UpdatePassword(string oldpass, AccountBE business) => throw new NotImplementedException();
    }
}
