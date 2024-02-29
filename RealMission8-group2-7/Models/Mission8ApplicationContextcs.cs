using Microsoft.EntityFrameworkCore;
using RealMission8_group2_7.Models;

namespace RealMission8_group2_7.Models
{
    public class Mission8ApplicationContext : DbContext
    {
        public Mission8ApplicationContext(DbContextOptions<Mission8ApplicationContext> options) : base(options)
        {
        }

        public DbSet<TaskModel> Tasks { get; set; } //test


    }
}


