using System;

namespace GamesNetwork.Domain.Games
{
    public class Rating
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public Game Game { get; set; }
        public DateTime RatingDate { get; set; }
    }
}