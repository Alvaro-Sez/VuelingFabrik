using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace VuelingFabrik.Domain
{
    public class OrderDto
    {
        [JsonPropertyName("Order")]
        public string Id { get; set; }
        [JsonPropertyName("Detail")]
        public List<ComponentDto> Detail { get; set; }

    }
}
