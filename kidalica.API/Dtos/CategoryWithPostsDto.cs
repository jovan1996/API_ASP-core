using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kidalica.API.Dtos
{
    public class CategoryWithPostsDto : BaseDto
    {
        public string Name { get; set; }
        public List<PostDto> Posts { get; set; }
    }
}
