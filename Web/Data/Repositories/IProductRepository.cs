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
    }
}