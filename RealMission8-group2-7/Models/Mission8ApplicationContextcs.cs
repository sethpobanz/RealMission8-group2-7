using Microsoft.EntityFrameworkCore;
using Real_Mission8_group2_7.Models;

namespace Real_Mission8_group2_7.Models
{
    public class Mission8ApplicationContext : DbContext
    {
        public Mission8ApplicationContext(DbContextOptions<Mission8ApplicationContext> options) : base(options)
        {
        }

        public DbSet<TaskModel> Tasks { get; set; } //test


    }
}


