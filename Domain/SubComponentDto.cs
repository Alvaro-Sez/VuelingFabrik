using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace VuelingFabrik.Domain
{
    public class SubComponentDto
    {

        [JsonPropertyName("Type")]
        public string Type { get; set; }
        [JsonPropertyName("Price")]
        public double Price { get; set; }
    }
}
