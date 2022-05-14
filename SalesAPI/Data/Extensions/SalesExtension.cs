using SalesAPI.Data.Models;

namespace SalesAPI.Data.Extensions
{
    public static class SalesExtension
    {
        public static void Update(this SalesItem listing, SalesItem update)
        {
            listing.Title = update.Title;
            listing.Description = update.Description;
            listing.Images = update.Images;
            listing.ListingTime = update.ListingTime;
            listing.Location = update.Location;
            listing.ContactInfo = update.ContactInfo;
        }
    }
}
