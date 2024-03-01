using System.ComponentModel.DataAnnotations;

namespace RealMission8_group2_7.Models
{
    public class Categories
    {
        [Key]
        [Required]
        public int CategoryId { get; set; }

        [Required]
        public string Category { get; set; }
    }
}
