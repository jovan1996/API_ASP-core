using kidalica.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kidalica.API.Dtos
{
    public class PostDto : BaseDto
    {
     
        
        public string Heading { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string Src { get; set; }

        public List<Category> Categories { get; set; }
        public AutorDto Autor { get; set; }

    }
}
