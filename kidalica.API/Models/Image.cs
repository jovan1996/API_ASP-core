using System;
using System.Collections.Generic;

namespace kidalica.API.Models
{
    public partial class Image : BaseEntity
    {
        public Image()
        {
            Post = new HashSet<Post>();
        }

   
        public string Src { get; set; }
        public string Alt { get; set; }
        public string Title { get; set; }

        public ICollection<Post> Post { get; set; }
    }
}
