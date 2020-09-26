using Microsoft.EntityFrameworkCore;
using Schoolmanagement.Entities;
using System;

namespace Schoolmanagement.DataLayer
{
    public class SchoolDbContext : DbContext
    {
        public SchoolDbContext(DbContextOptions<SchoolDbContext> dbContextOptions)
            : base(dbContextOptions)
        {
            //Database.Migrate();
        }
        public DbSet<Notice> Notices { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Library> Libraries { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<BookBorrow> BookBorrows { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Notice>()
                .HasKey(x => x.NoticeId);
            modelBuilder.Entity<Student>()
                .HasKey(x => x.StudentId);
            modelBuilder.Entity<Library>()
                .HasKey(x => x.BookId);
            modelBuilder.Entity<Teacher>()
                .HasKey(x => x.TeacherId);
            modelBuilder.Entity<BookBorrow>()
                .HasKey(x => x.BorrowId);
            base.OnModelCreating(modelBuilder);
        }
    } 
}
