namespace AWWW_Lab2.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Title { get; set; } = "";
        public string Content { get; set; } = "";
        public virtual Article Article { get; set; } = null!;
        public virtual int ArticleId { get; set; }
    }
}
