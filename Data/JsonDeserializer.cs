using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using VuelingFabrik.Domain;

namespace VuelingFabrik.Data
{
    public class JsonDeserializer
    {
        public OrderDto GetOrder()
        {
            string workingDirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
            string json = File.ReadAllText(Path.Combine(projectDirectory,@"Data\order.json"));
            OrderDto order = JsonSerializer.Deserialize<OrderDto>(json);

            return order;

        }
    }
}
