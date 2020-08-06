using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xl.UIComponent
{
    public class PageabledEventArgs : QueryParameterEventArgs
    {

       
        public PageabledEventArgs()
        {

            this.PageIndex = 1;
            this.PageSize = 25;
            this.TotalCount = 0;


        }
        /// <summary>
        /// 索引
        /// </summary>
        public int PageIndex { get; set; }
        /// <summary>
        /// 显示条数
        /// </summary>
        public int PageSize { get; set; }
        /// <summary>
        /// 数据总条数
        /// </summary>
        public int TotalCount { get; set; }
     

        /// <summary>
        /// 分页数
        /// </summary>
        public int PageCount
        {
            get { return Convert.ToInt32(Math.Ceiling(TotalCount / PageSize * 1.0)); }
        }


    }
}
