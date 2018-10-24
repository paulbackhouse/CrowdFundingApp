using System;
using System.ComponentModel.DataAnnotations;

namespace Web.Models
{
    public class InvestmentLedgerEntity : BaseEntity<long>
    {

        [Key]
        // HACK: Change to correct type as User auth and management is added
        public Guid UserId { get; set; }

        [Key]
        public int ProductId { get; set; }

        [Range(100, 10000)]
        public decimal Amount { get; set; }

    }
}
