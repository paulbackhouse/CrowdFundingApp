using System.Linq;
using Web.Models;

namespace Web.Data
{
    public static class DbInitialiser
    {
        private static CrowdFundingContext context;

        public static void Initialize(CrowdFundingContext ctx)
        {
            context = ctx;

            context.Database.EnsureCreated();

            Products();

        }

        // add products
        private static void Products()
        {
            // TODO: DATA: SEED: Products > update to real investment products
            if (!context.Product.Any())
            {
                var text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas convallis aliquam augue, ut porttitor massa aliquam non. Aenean sed sodales risus, ut congue velit.";

                for (var i = 1; i < 11; i++)
                {
                    context.Add(new ProductEntity { Name = $"Investment {i}", Description = text, InvestmentRequired = (i * 11000), InvestmentAmount = 0 });
                }

                context.SaveChanges();
            }
        }

    }
}
