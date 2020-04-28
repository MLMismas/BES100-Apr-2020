﻿using Microsoft.EntityFrameworkCore;

namespace LibraryApi.Domain
{
    public class LibraryDataContext : DbContext
    {
        public LibraryDataContext(DbContextOptions<LibraryDataContext> ctx): base(ctx) { }

        public virtual DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().Property(b => b.Title).HasMaxLength(200);
            modelBuilder.Entity<Book>().Property(b => b.Author).HasMaxLength(200);
        }
    }
}
