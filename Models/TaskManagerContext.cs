using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskManager.Models
{
    public class TaskManagerContext : DbContext
    {
        public TaskManagerContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<TaskModel> Tasks { get; set; }
        public DbSet<Priorities> Priorities { get; set; }
        public DbSet<Quotes> Quotes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TaskModel>()
                .HasOne(t => t.Priority)
                .WithMany(p => p.Tasks)
                .HasForeignKey(t => t.PriorityId);

            modelBuilder.Entity<TaskModel>(entity =>
            {
                entity.Property(e => e.Done)
                      .HasColumnType("bit")
                      .IsRequired();
            });

            modelBuilder.Entity<Priorities>(entity =>
            {
                entity.HasKey(e => e.PriorityId);
                entity.Property(e => e.PriorityType).IsRequired();
                entity.Property(e => e.Reason);
            });

        }


    }
}
