using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Real_Mission8_group2_7.Models
{
    public class TaskModel
    {
        [Required]
        [Key]
        public int TaskId { get; set; }
        public string task { get; set; }
        public DateOnly? duedate { get; set; }
        public string quadrant { get; set; }
        public int? category { get; set; }
        public bool? completed { get; set; }

    }
}
