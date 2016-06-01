using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Boreal.Model;
using IQ.Foundation;
using IQ.Platform.Framework.WebApi;

namespace Boreal.ApiServices
{
    public class ProductApiServices : IProductApiServices
    {
        private BorealPersistence.IRepository<Product, int> _repo;

        public ProductApiServices(BorealPersistence.IRepository<Product, int> repo)
        {
            _repo = repo;
        }
        public Task<Product> GetAsync(int id, IRequestContext context, CancellationToken cancellation)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Product>> GetManyAsync(IRequestContext context, CancellationToken cancellation)
        {
            throw new NotImplementedException();
        }

        public Task<ResourceCreationResult<Product, int>> CreateAsync(Product resource, IRequestContext context, CancellationToken cancellation)
        {
            throw new NotImplementedException();
        }

        public Task<Product> UpdateAsync(Product resource, IRequestContext context, CancellationToken cancellation)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(ResourceOrIdentifier<Product, int> input, IRequestContext context, CancellationToken cancellation)
        {
            throw new NotImplementedException();
        }
    }
}
