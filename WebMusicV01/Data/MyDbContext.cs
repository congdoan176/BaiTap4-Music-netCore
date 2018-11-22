using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMusicV01.Models;

namespace WebMusicV01.Data
{
    public class MyDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=MusicV001;Trusted_Connection=True;MultipleActiveResultSets=true");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SongCategory>()
                .HasKey(sc => new { sc.SongId, sc.CategoryId });
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<WebMusicV01.Models.Song> Song { get; set; }
        public DbSet<WebMusicV01.Models.Category> Category { get; set; }
        public DbSet<WebMusicV01.Models.SongCategory> SongCategory { get; set; }
    }
}
