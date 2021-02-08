using GamesNetwork.Domain.Games;
using GamesNetwork.EntityFrameworkCore.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Diagnostics;
using System.Linq;
using Xunit;

namespace GamesNetwork.Tests
{
    public class DatabaseTests
    {
        [Fact]
        public void TestIfCanAddGameToDataBase()
        {
            var builder = new DbContextOptionsBuilder();
            builder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=TestGamesDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            using (var context = new GamesNetworkDbContext(builder.Options))
            {
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();

                var game = new Game()
                {
                    Name = "Super Mario Sunshine",
                    ImageUrl = "notfound",
                    ReleaseDate = DateTime.Parse("2005-01-01")
                };

                context.Games.Add(game);
                Debug.WriteLine($"Before save: { game.Id}");
                context.SaveChanges();
                Debug.WriteLine($"After save: { game.Id}");

                Assert.Equal(1, context.Games.Count());
            }
        }
    }
}
