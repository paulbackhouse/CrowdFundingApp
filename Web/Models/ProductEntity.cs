using System.ComponentModel.DataAnnotations;

namespace Web.Models
{
    public class ProductEntity : BaseEntity<int>
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        /// <summary>
        /// the required amount of investment
        /// </summary>
        [Range(100, double.MaxValue)]
        public decimal InvestmentRequired { get; set; }

        /// <summary>
        /// a running total of what has been achieved investment wise
        /// </summary>
        [Range(0, double.MaxValue)]
        public decimal InvestmentAmount { get; set; }

        /// <summary>
        /// has the investment required been reached?
        /// </summary>
        // TODO: DATA: this should be set in business logic and not on the entity
        public bool InvestmentComplete => InvestmentAmount == InvestmentRequired;
    }
}
