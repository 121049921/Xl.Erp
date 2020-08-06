using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xl.Model
{
    public class RequiredAttribute : Attribute
    {
        public string ErrorMessage { get; set; }
        public RequiredAttribute(string errorMessage)
        {
            this.ErrorMessage = errorMessage;

        }
    }
    public class MaxLengthAttribute : Attribute
    {
        public string ErrorMessage { get; set; }
        public int Length { get; set; }
        public MaxLengthAttribute(int length, string errorMessage)
        {
            this.ErrorMessage = errorMessage;
            this.Length = length;
        }
    }
}
