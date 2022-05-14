using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SalesAPI.Data.Models
{
    public class SalesItem
    {
     
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }


        [Required]
        public Guid UserID { get; set; }

        [Required]
        [MinLength(5)]
        [MaxLength(75)]
        public string Title { get; set; }  = string.Empty;

        [Required]
        [MinLength(5)]
        public string Description { get; set; } = string.Empty;

        public ICollection<ImageItem> Images { get; set; } = new List<ImageItem>();

        [Required]
        public DateTime ListingTime { get; set; }

        public string Location { get; set; } = string.Empty;

        public string ContactInfo { get; set; } = string.Empty;
    }
}
