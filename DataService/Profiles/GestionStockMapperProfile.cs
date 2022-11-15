using AutoMapper;
using BusnessEntities.Dtos;
using DataModel.SPEntities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataService.Profiles
{
    public class GestionStockMapperProfile : Profile
    {
        public GestionStockMapperProfile()
        {
            CreateMap<AccountSP, AccountDTO>().ReverseMap();
        }
    }
}
