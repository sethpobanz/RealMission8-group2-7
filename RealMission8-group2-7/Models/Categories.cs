using System.ComponentModel.DataAnnotations;

namespace RealMission8_group2_7.Models
{
    public class Categories
    {
        [Key]
        public int CategoryId { get; set; }

        public string Category { get; set; }
    }
}
