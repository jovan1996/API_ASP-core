using System;
using System.Collections.Generic;

namespace kidalica.API.Models
{
    public partial class Autor : BaseEntity
    {
        public Autor()
        {
            Post = new HashSet<Post>();
        }

        
        public string Name { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string PasswordSalt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime CreatedAt { get; set; }

        public ICollection<Post> Post { get; set; }
    }
}
