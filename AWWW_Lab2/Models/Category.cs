﻿namespace AWWW_Lab2.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public virtual ICollection<Article>? Articles { get; set; }
    }
}
