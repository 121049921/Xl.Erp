using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xl.UIComponent
{
    /// <summary>
    /// 绑定的列名
    /// </summary>
    public class BindGridColumn
    {
        /// <summary>
        /// 字段名称,中文
        /// </summary>
        public string HeaderText { get; set; }
        /// <summary>
        /// 属性名
        /// </summary>
        public string PropertieName { get; set; }
        /// <summary>
        /// 属性类型
        /// </summary>
        public Type PropertieType { get; set; }
    }
}
