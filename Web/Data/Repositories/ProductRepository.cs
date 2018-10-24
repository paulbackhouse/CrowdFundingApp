using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Web.Models;

namespace Web.Data.Repositories
{
    // TODO: DATA: REPO: replace with valid data access logic (nosql / M(x) SQL EF context)
    public class ProductRepository : BaseRepository, IProductRepository
    {
        public ProductRepository(CrowdFundingContext ctx)
            : base(ctx)
        { }

        // TODO: CACHE: PAGING: add
        public async Task<IEnumerable<ProductEntity>> Get()
        {
            return await context.Product.ToListAsync();
        }

        // TODO: PAGING: add
        public async Task<ProductEntity> Get(int id)
        {
            return await context.Product.FirstOrDefaultAsync(f => f.Id == id);
        }

        // TODO: DATA: consider Upsert logic
        public void Save(ProductEntity entity)
        {
            entity.Updated = DateTime.UtcNow;
            context.Product.Update(entity);
        }

    }
}
