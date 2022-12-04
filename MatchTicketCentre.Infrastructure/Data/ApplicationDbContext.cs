using MatchTicketCentre.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MatchTicketCentre.Infrastructure.Data
{
    public class ApplicationDbContext : IdentityDbContext<User, Role, string, IdentityUserClaim<string>, UserRole, IdentityUserLogin<string>, IdentityRoleClaim<string>, IdentityUserToken<string>>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Country> Countries { get; set; } = null!;
        public DbSet<League> Leagues { get; set; } = null!;
        public DbSet<Fixture> Fixtures { get; set; } = null!;
        public DbSet<Stadium> Stadiums { get; set; } = null!;
        public DbSet<Team> Teams { get; set; } = null!;
        public DbSet<Ticket> Tickets { get; set; } = null!;
        public DbSet<Town> Towns { get; set; } = null!;
        public DbSet<UserCard> UserCards { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<User>(u =>
            {
                u.Property(u => u.UserName).HasMaxLength(25).IsRequired();
                u.Property(u => u.NormalizedUserName).HasMaxLength(25);
                u.Property(u => u.Email).HasMaxLength(25).IsRequired();
                u.Property(u => u.NormalizedUserName).HasMaxLength(25);
                u.Property(u => u.PhoneNumber).HasMaxLength(15).IsRequired();

            });

            builder.Entity<UserRole>(ur =>
            {
                ur.HasOne(ur => ur.User).WithMany(u => u.UsersRoles).HasForeignKey(ur => ur.UserId);
                ur.HasOne(ur => ur.Role).WithMany(u => u.UsersRoles).HasForeignKey(ur => ur.RoleId);
            });

            builder.Entity<Stadium>()
                .Property(s => s.IsSold)
                .HasDefaultValue(false);

            builder.Entity<Fixture>()
                .Property(s => s.IsFinished)
                .HasDefaultValue(false);

            builder.Entity<UserCard>(sc =>
            {  
                sc.HasOne(uc => uc.User).WithMany(s => s.UserCards).OnDelete(DeleteBehavior.Restrict);
            });
        }


    }
}