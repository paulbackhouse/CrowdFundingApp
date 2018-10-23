using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Web.Models;

namespace Web.Data.Repositories
{
    public  interface IInvestmentLedgerRepository
    {
        /// <summary>
        /// gets an enumerable of investments for a given user
        /// </summary>
        Task<IEnumerable<InvestmentLedgerEntity>> Get(Guid userId);

        /// <summary>
        /// save an investment
        /// </summary>
        Task Save(InvestmentLedgerEntity entity);
    }
}