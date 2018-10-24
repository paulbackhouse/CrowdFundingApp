namespace Web.Data.Repositories
{
    public class BaseRepository
    {
        // TODO: DATA: if EF implementation create generic repository<TEntityType> 
        protected CrowdFundingContext context;

        public BaseRepository(CrowdFundingContext context)
        {
            this.context = context;
        }
    }
}
