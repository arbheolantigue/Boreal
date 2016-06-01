using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Boreal.Model;
using IQ.Platform.Framework.WebApi;

namespace Boreal.ApiServices
{
    interface IProductApiServices
        :
        IGetAResourceAsync<Product, int>,
        IGetManyOfAResourceAsync<Product, int>,
        ICreateAResourceAsync<Product, int>,
        IUpdateAResourceAsync<Product, int>,
        IDeleteResourceAsync<Product, int>
    {
    }
}
