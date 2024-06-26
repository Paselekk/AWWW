﻿using Microsoft.VisualBasic;
namespace AWWW_Lab2.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public virtual ICollection<Article>? Articles { get; set; }
    }
}
