using Microsoft.EntityFrameworkCore;

namespace Web.Data
{
    using Models;

    // TODO: DATA: CONTEXT: update to final data store implementation (nosql / M(x) sql EF)
    public class CrowdFundingContext : DbContext
    {

        // cstr
        public CrowdFundingContext()
        { }

        // cstr
        public CrowdFundingContext(DbContextOptions<CrowdFundingContext> options)
            : base(options)
        {
        }


        // e n t i t i e s

        public DbSet<ProductEntity> Product { get; set; }

        public DbSet<InvestmentLedgerEntity> InvestmentLedge { get; set; }


        // p r o t e c t e d

        protected override void OnModelCreating(ModelBuilder builder)
        {
            // composite key
            builder.Entity<InvestmentLedgerEntity>()
                .HasKey(k => new { k.Id, k.UserId, k.ProductId });

            base.OnModelCreating(builder);
        }

    }
}
