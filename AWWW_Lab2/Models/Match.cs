﻿namespace AWWW_Lab2.Models
{
    public class Match
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Stadium { get; set; } = "";
        public virtual ICollection<Article>? Articles { get; set; }
        public virtual ICollection<MatchEvent>? MatchEvents { get; set; }
        public virtual ICollection<MatchPlayer>? Player { get; set; }
        public virtual Team HomeTeam { get; set; } = null!;
        public virtual int HomeTeamId { get; set; }
        public virtual Team AwayTeam { get; set; } = null!;
        public virtual int AwayTeamId { get; set; }

    }
}
