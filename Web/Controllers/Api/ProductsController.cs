using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers.Api
{
    using Data.Repositories;
    using Web.Models;

    public class ProductsController : ApiController
    {

        private readonly IProductRepository productRepository;

        public ProductsController(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }


        [HttpGet]
        // TODO: API: should return a DTO, not direct entities
        public async Task<IEnumerable<ProductEntity>> Get()
            => await productRepository.Get();

    }
}