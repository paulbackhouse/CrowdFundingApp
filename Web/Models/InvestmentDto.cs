using System;
using System.ComponentModel.DataAnnotations;

namespace Web.Models
{
    public class InvestmentDto
    {
        [Required]
        public Guid UserId { get; set; }

        [Required]
        [Range(1, int.MaxValue)]
        public int ProductId { get; set; }

        [Range(100, 10000)]
        public decimal Amount { get; set; }
    }
}
