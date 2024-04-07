using Microsoft.EntityFrameworkCore;
using Models = Task_Tracker_App.Models;

namespace Task_Tracker_App.Data
{
    public class TaskTrackerAppContext : DbContext
    {
        public DbSet<Models.Task> Tasks { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-AV8L5D2\\SQLEXPRESS;Initial Catalog=TaskTrackerApp;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }
    }
}
