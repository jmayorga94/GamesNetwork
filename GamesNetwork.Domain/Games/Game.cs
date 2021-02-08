using System;
using System.Collections.Generic;
using System.Text;

namespace GamesNetwork.Domain.Games
{
    public class Game
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }

        public string ImageUrl { get; set; }
        public IList<Rating> Ratings { get; set; } = new List<Rating>();
    }
}
