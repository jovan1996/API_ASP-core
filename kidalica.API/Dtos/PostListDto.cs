using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kidalica.API.Dtos
{
    public class PostListDto : BaseDto
    {
        public List<CategoryDto> Categories { get; set; }
        public ImageDto Image { get; set; }
        public AutorDto Autor { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        
    }
}
