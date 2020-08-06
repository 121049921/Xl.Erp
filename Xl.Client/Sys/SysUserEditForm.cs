using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xl.Model;
using Xl.UIComponent;

namespace Xl.Client
{
    public partial class SysUserEditForm : EditBaseForm
    {
        public SysUserEditForm()
        {
            InitializeComponent();
        }

        private void SysUserEditForm_Load(object sender, EventArgs e)
        {

        }
       

        protected override bool OnSaveBefor()
        {
            if (string.IsNullOrEmpty(this.txt_Password.Text.Trim()))
            {
                return ValidateTip(txt_Password, "密码不允许为空");
            }
            if (string.IsNullOrEmpty(this.txt_UserName.Text.Trim()))
            {
                return ValidateTip(txt_UserName, "用户名不允许为空");
            }
            return true;
        }
        protected override bool OnSaveAfter()
        {

            return base.OnSaveAfter();
         }
    }
}
