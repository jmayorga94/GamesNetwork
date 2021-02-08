using GamesNetwork.Domain.Games;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamesNetwork.EntityFrameworkCore.Context
{
    public class GamesNetworkDbContext : DbContext
    {
        public GamesNetworkDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Game> Games { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Game>().HasMany(x => x.Ratings);
            modelBuilder.Entity<Game>().Property(x => x.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<Rating>().Property(x => x.RatingDate).HasDefaultValueSql("getDate()");
        }
    }
}
