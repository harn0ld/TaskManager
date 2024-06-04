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
        public DbSet<State> State { get; set; }


        /// //////////////////////////////////
        public DbSet<Login> Logins { get; set; }
        /// //////////////////////



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


            //////
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Login>().HasData(
                new Login { Id = 1, Username = "test", PasswordHash = ComputeHash("password") }
            );
            ///////
            ///
        }

        private string ComputeHash(string input)
        {
            using (var md5 = System.Security.Cryptography.MD5.Create())
            {
                var bytes = md5.ComputeHash(System.Text.Encoding.UTF8.GetBytes(input));
                var sb = new System.Text.StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    sb.Append(bytes[i].ToString("x2"));
                }
                return sb.ToString();
            }
        }
        


    }
}
