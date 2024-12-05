using Hubsta.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace Hubsta.Data
{
    public class ApplicationDbContext : IdentityDbContext<AppUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<FriendRelation>()
            .HasOne(fr => fr.User1)
            .WithMany(u => u.FriendRelations)
            .HasForeignKey(fr => fr.User1Id)
            .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<FriendRelation>()
                .HasOne(fr => fr.User2)
                .WithMany(u => u.FriendRelations)
                .HasForeignKey()
                .OnDelete(DeleteBehavior.Restrict);
        }

        public DbSet<Post> Posts { get; set; }
        public DbSet<FriendRelation> FriendRelations { get; set; }
    }
}
