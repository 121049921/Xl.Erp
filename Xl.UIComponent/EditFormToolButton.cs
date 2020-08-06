using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xl.UIComponent
{
    [Flags]
    /// <summary>
    /// 和工具栏上的按钮对应上
    /// </summary>
    public enum EditFormToolButton
    {
        /// <summary>
        /// 保存
        /// </summary>
        btnSave = 1,
        /// <summary>
        /// 保存并新增
        /// </summary>
        btnSaveAndNew = 2,
        /// <summary>
        /// 关闭
        /// </summary>
        btnClose = 4,
    }
}

