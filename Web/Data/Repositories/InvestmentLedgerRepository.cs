using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Web.Models;

namespace Web.Data.Repositories
{
    public class InvestmentLedgerRepository : BaseRepository, IInvestmentLedgerRepository
    {

        // cstr
        public InvestmentLedgerRepository(CrowdFundingContext ctx)
            : base(ctx)
        {
        }

        // TODO: REPO: Add logic here to retrieve investments for a given user
        // TODO: PAGING: consider requirement
        public async Task<IEnumerable<InvestmentLedgerEntity>> Get(Guid userId)
        {
            throw new NotImplementedException();
        }


        public async Task Save(InvestmentLedgerEntity entity)
        {
            await context.InvestmentLedge.AddAsync(entity);
        }



    }
}
