using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RealMission8_group2_7.Models
{
    public class TaskModel
    {
        [Required]
        [Key]
        public int TaskId { get; set; }
        [Required]
        public string task { get; set; }
        public DateOnly? duedate { get; set; }
        [Required]
        public string quadrant { get; set; }
        [ForeignKey("Categories")]
        public int? CategoryId { get; set; }
        public Categories Categories { get; set; }
        public bool? completed { get; set; }

    }
}
