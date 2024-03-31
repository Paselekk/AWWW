﻿namespace AWWW_Lab2.Models
{
    public class Player
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public string Country { get; set; } = "";
        public DateTime BirthDate { get; set; }
        public virtual Team Team { get; set; } = null!;
        public virtual int TeamId { get; set; }
        public virtual ICollection<Position> Positions { get; set; } = null!;
        public virtual ICollection<MatchPlayer>? MatchPlayers { get; set; }
    }
}
