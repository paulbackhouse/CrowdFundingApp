using Microsoft.AspNetCore.Mvc;
using Web.Data.Repositories;
using Web.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Web.Controllers.Api
{
    public class LedgerController : ApiController
    {
        private readonly IInvestmentLedgerRepository investmentLedgerRepository;
        private readonly IProductRepository productRepository;

        public LedgerController(IInvestmentLedgerRepository investmentLedgerRepository, IProductRepository productRepository)
        {
            this.investmentLedgerRepository = investmentLedgerRepository;
            this.productRepository = productRepository;
        }

        // POST api/<controller>
        [HttpPost]
        public IActionResult Post([FromBody]InvestmentDto model)
        {
            // TODO: MODELSTATE: create generic model state filter for all requests
            if (ModelState.IsValid)
            {
                // TODO: BUSINESS LOGIC: add a service for this logic, valid product, update product once ledger updated etc...

                var tsk = productRepository.Get(model.ProductId);
                tsk.Wait();

                if (tsk.Result != null)
                {

                    // TODO: BUSINESS LOGIC: create InvestmentLedgerService that handles this
                    var entity = new InvestmentLedgerEntity
                    {
                        ProductId = model.ProductId,
                        UserId = model.UserId,
                        Amount = model.Amount
                    };

                    investmentLedgerRepository.Save(entity);

                    tsk.Result.InvestmentAmount = tsk.Result.InvestmentAmount + model.Amount;
                    productRepository.Save(tsk.Result);

                    return Ok(tsk.Result);
                }

                return BadRequest("Product Id is invalid!");
            }

            return BadRequest("Product Id, User Id & Amount should be set, post is invalid!");

        }

    }
}
