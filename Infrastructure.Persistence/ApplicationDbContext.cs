using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options)
            : base(options)
        {

        }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<File> Files { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<AccountRole> AccountRoles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<AccountRole>(entity =>
            {
                entity.HasKey(ar => new { ar.AccountId, ar.RoleId });
            });

            modelBuilder.Entity<Blog>(entity =>
            {
                entity.HasOne(blog => blog.Account)
                    .WithMany(account => account.Blogs)
                    .HasForeignKey(blog => blog.AccountId)
                    .OnDelete(DeleteBehavior.NoAction)
                ;
            });

            modelBuilder.Entity<File>(entity =>
            {
                entity.HasOne(file => file.Account)
                    .WithMany(account => account.Files)
                    .HasForeignKey(blog => blog.AccountId)
                    .OnDelete(DeleteBehavior.NoAction)
                ;
            });

            modelBuilder.Entity<Role>(entity =>
            {

            });

            modelBuilder.Entity<Account>(entity =>
            {

            });


        }

    }
}
