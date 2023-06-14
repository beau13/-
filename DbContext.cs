using Microsoft.EntityFrameworkCore;
using System;

namespace WindowsFormsApp1 {
    public class AppContext : DbContext {
        public DbSet<Task> Tasks { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //    => optionsBuilder.UseSqlite("Data Source=diary.db");

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<Task>().HasData(
                new Task { TaskId = 1, Time = DateTime.Now, Name = "Текущая задача" },
                new Task { TaskId = 2, Time = DateTime.Today, Name = "Ещё одна задача" }
            );
        }
    }
}
