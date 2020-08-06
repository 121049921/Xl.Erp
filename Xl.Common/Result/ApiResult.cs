using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xl.Common
{
    public class ApiResult<T> : IResult<T>
    {
        public T Data { get; set; }
        public bool IsSuccess { get; set; }

        public bool Message { get; set; }
    }
}
