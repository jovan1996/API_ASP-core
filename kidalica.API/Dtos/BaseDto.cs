using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kidalica.API.Dtos
{
    public class BaseDto
    {
        [JsonProperty("id")]
        public int Id{ get; set; }

        [JsonProperty("createdAt")]
        public DateTimeOffset CreatedDate { get; set; }
    }
}
