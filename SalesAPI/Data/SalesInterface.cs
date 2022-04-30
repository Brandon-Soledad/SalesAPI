using System.ComponentModel.DataAnnotations;

namespace SalesAPI.Data
{
    public class SalesInterface
    {
        [Required]
        public Guid UserID { get; set; }

        [Required]
        [MinLength(5)]
        [MaxLength(75)]
        public String Title { get; set; }  = String.Empty;

        [MaxLength(5000)]
        public String Description { get; set; } = String.Empty;

        public List<String> Images { get; set; } = new List<String>();

        public DateTime ListingTime { get; set; }

        public String Location { get; set; } = String.Empty;

        public String ContactInfo { get; set; } = String.Empty;
    }
}
