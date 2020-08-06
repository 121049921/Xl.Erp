using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xl.UIComponent
{
    /// <summary>
    /// 关健字查询
    /// </summary>
    public class QueryParameterEventArgs<T> : EventArgs
    {
        /// <summary>
        /// 关健字
        /// </summary>
        public string Key { get; set; }
        /// <summary>
        /// 名称 
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 开始时间
        /// </summary>
        public DateTime StartTime { get; set; }
        /// <summary>
        /// 结束时间
        /// </summary>
        public DateTime EndTime { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
        public T Status { get; set; }
    }

    /// <summary>
    /// 关健字查询
    /// </summary>
    public class QueryParameterEventArgs : QueryParameterEventArgs<int>
    {
        
    }
}
