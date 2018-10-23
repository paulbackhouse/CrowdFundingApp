using Microsoft.EntityFrameworkCore;
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

        public async Task<IEnumerable<ProductEntity>> Get()
        {
            return await context.Product.ToListAsync();
        }

    }
}
