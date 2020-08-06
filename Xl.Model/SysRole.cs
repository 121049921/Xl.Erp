using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xl.Model
{
    /// <summary>
    /// 角色
    /// </summary>
    public class SysRole: BaseEntity
    {
        [Required("名称必填")]
        [DisplayName("名称")]
        public string Name { get; set; }
    }
}
