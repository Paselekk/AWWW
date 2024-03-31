namespace AWWW_Lab2.Models
{
    public class EventType
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public virtual ICollection<MatchEvent>? MatchEvents { get; set; }
    }
}
