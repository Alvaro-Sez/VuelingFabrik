using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VuelingFabrik.Domain;

namespace VuelingFabrik.Application.Validation
{
    public class ValidationResult
    {
        public bool IsValid { get; set; } = false;
        public List<TestError> ErrorList { get; set; } = new List<TestError>();

        public void AddResult(ValidationContext context)
        {
            if(context.ErrorList.Count>0)
            {
                ErrorList = context.ErrorList;
            }
            else
            {
                IsValid = true;
            }
        }
    }
}
