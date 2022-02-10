using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace VuelingFabrik.Domain
{
    public class ComponentDto
    {
        [JsonPropertyName("ComponentType")]
        public string ComponentType { get; set; }
        [JsonPropertyName("Subcomponents")]
        public List<SubComponentDto> SubComponents { get; set; }
        [JsonPropertyName("PriceIncrement")]
        public double PriceIncrement { get; set; }
        [JsonPropertyName("NumComponents")]
        public int NumComponents { get; set; }
        [JsonPropertyName("Color")]
        public string Color { get; set; }
        [JsonPropertyName("Tests")]
        public List<string>Tests { get; set; }
    }
}
