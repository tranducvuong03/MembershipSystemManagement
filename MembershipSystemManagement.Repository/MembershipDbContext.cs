using MembershipSystemManagement.Repository.Entities;
using Microsoft.EntityFrameworkCore;

namespace MembershipSystemManagement.Repository
{
    public class MembershipDbContext : DbContext
    {
        public MembershipDbContext(DbContextOptions<MembershipDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<LocalAuthentication> LocalAuthentication { get; set; }
        public DbSet<SocialAuthentication> SocialAuthentication { get; set; }
        public DbSet<Role> Roles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
