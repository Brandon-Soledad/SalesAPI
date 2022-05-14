using SalesAPI.Data.Models;


namespace SalesAPI.Data.Extensions
{
    public static class SalesDBExtension
    {
        public static void Update(this DbSet<SalesItem> saleListings, SalesItem current, SalesItem updated)
        {
            current.Update(updated);
            saleListings.Update(current);
        }
    }
}
