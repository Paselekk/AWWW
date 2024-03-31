﻿namespace AWWW_Lab2.Models
{
    public class Position
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public virtual ICollection<MatchPlayer>? MatchPlayers { get; set; }
        public virtual ICollection<Player>? Players { get; set; }
    }
}
