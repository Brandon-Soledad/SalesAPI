using System.ComponentModel.DataAnnotations;

namespace SalesAPI.Data.Models
{
    public class ImageItem
    {
        [Key]
        public int Id { get; set; }
        public string Uri { get; set; } = null!;
    }
}
