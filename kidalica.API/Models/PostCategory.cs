using System;
using System.Collections.Generic;

namespace kidalica.API.Models
{
    public partial class PostCategory
    {
        public int IdPost { get; set; }
        public int IdCategory { get; set; }

        public Category IdCategoryNavigation { get; set; }
        public Post IdPostNavigation { get; set; }
    }
}
