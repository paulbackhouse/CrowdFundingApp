namespace Web.Data.Repositories
{
    public class BaseRepository
    {
        protected CrowdFundingContext context;

        public BaseRepository(CrowdFundingContext context)
        {
            this.context = context;
        }
    }
}
