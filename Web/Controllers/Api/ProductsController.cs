using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Web.Controllers.Api
{
    using Data.Repositories;
    using Web.Models;

    public class ProductsController : ApiController
    {
        // TODO: BUSINESS LOGIC: create 'ProductService.cs IProductServive' should return a cached instance of products
        private readonly IProductRepository productRepository;

        public ProductsController(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }


        [HttpGet]
        // TODO: BUSINESS LOGIC: ProductService should return a cached instance of the product, should return a DTO, not direct 'ProductEntity'
        public async Task<IEnumerable<ProductEntity>> Get()
            => await productRepository.Get();

    }
}