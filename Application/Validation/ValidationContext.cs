using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VuelingFabrik.Domain;

namespace VuelingFabrik.Application.Validation
{
    public class ValidationContext
    {
        public List<Component> Components { get; set; }
        public List<TestError> ErrorList { get; set; } = new List<TestError>();
        public OrderDto Order { get; set; }

        public void AddError(TestError Err)
        {
            ErrorList.Add(Err);
        }
    }
}
