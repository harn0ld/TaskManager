using Microsoft.EntityFrameworkCore;
using TaskProgram.Models;

namespace TaskProgram.Models
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Login> Logins { get; set; }
        public DbSet<Data> Datas { get; set; }

        public ApplicationDbContext(){}
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Login>().HasData(
                new Login { Id = 1, Username = "test", PasswordHash = ComputeHash("password") }
            );

            modelBuilder.Entity<Data>().HasData(
                new Data { Id = 1, Content = "Sample Data" }
            );
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