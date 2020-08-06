using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xl.Model
{
    /// <summary>
    /// 员工
    /// </summary>
    public class SysUser : BaseEntity
    {
        [Required("名称必填")]
        [DisplayName("名称")]
        public string Name { get; set; }
        [DisplayName("登陆名")]
        public string LoginName { get; set; }
        [DisplayName("出生年月")]
        public DateTime BrithDay { get; set; } = DateTime.Now;
        [DisplayName("是否管理员")]
        public bool IsAdmin { get; set; } = false;
        [DisplayName("性别")]
        public Sex Sex { get; set; }
        [DisplayName("密码")]
        public string Password { get; set; }
    }

    public enum Sex
    {
        [Description("男")]
        Men = 1,
        [Description("女")]
        WonMen = 2,
    }
}
