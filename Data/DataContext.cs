using Microsoft.EntityFrameworkCore;
using ZeroXTeam.Entities;

namespace ZeroXTeam.Data
{
    public class DataContext : DbContext
    {
        public DataContext( DbContextOptions options) : base(options)
        {
        }
        public DbSet<AdminAccount> AdminAccount {get; set;}
        public DbSet<HomePageInformation> HomePageInformation {get; set;}
        public DbSet<Member> Member {get; set;}
        public DbSet<Project> Project {get; set;}
        public DbSet<Blog> Blog {get; set;}
        public DbSet<Recruitment> Recruitment { get; set; }
        public DbSet<Contact> Contact { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);                
        }
    }
}