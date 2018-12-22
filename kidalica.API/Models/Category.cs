using System;
using System.Collections.Generic;

namespace kidalica.API.Models
{
    public partial class Category : BaseEntity
    {
        public Category()
        {
            PostCategory = new HashSet<PostCategory>();
        }

     
        public string Name { get; set; }

        public ICollection<PostCategory> PostCategory { get; set; }
    }
}
