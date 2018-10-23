using System.Collections.Generic;
using System.Threading.Tasks;
using Web.Models;

namespace Web.Data.Repositories
{
    public interface IProductRepository
    {
        /// <summary>
        /// gets an enumerable of products
        /// </summary>
        Task<IEnumerable<ProductEntity>> Get();

        /// <summary>
        /// gets a product for a given id reference
        /// </summary>
        Task<ProductEntity> Get(int id);

        /// <summary>
        /// saves (updates) an investment product
        /// </summary>
        void Save(ProductEntity entity);
    }
}