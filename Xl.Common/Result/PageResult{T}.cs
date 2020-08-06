using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xl.Common
{
    public class PageResult<T> : IResult<T>
    {
        public T Data { get; set; }
        public int Total { get; set; }
    }
}
