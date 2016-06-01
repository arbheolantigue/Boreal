using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Boreal.Model;
using IQ.Platform.Framework.WebApi.Errors;
using _m = BorealPersistence;
namespace Boreal.WebApi
{
    public class AutoMapperConfig
    {
        public static void RegisterMapping()
        {
            AutoMapper.Mapper.CreateMap<Employee, _m.Employee>()
                .ReverseMap();
            AutoMapper.Mapper.CreateMap<Product, _m.Product>()
                .ReverseMap();
            AutoMapper.Mapper.CreateMap<Customer, _m.Customer>()
                .ReverseMap();
            AutoMapper.Mapper.CreateMap<Warehouse, _m.Warehouse>()
                .ReverseMap();
            AutoMapper.Mapper.CreateMap<WarehouseItem, _m.WarehouseItem>()
                .ReverseMap();
        }

    }
}