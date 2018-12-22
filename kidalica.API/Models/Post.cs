using System;
using System.Collections.Generic;

namespace kidalica.API.Models
{
    public partial class Post : BaseEntity
    {
        public Post()
        {
            PostCategory = new HashSet<PostCategory>();
        }

        public int IdAutor { get; set; }
        public int IdImage { get; set; }
        public string Heading { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime? CreatedAt { get; set; }

        public Image IdAutor1 { get; set; }
        public Autor IdAutorNavigation { get; set; }
        public ICollection<PostCategory> PostCategory { get; set; }
    }
}
