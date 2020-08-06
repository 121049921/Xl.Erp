using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Xl.UIComponent
{
    public partial class LoginUI : UserControl
    {
        public LoginUI()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 登陆
        /// </summary>
        public event Action<string, string> Login;
        /// <summary>
        /// 
        /// </summary>
        public event Action Cancel;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.txtLoginName.Text))
            {
                balloonTip.SetBalloonCaption(this.txtPassword, "登陆名不能为空");
                
                DevComponents.DotNetBar.MessageBoxEx.Show("登陆名不能为空");
                return ;
            }
            if (string.IsNullOrWhiteSpace(this.txtPassword.Text))
            {
                balloonTip.SetBalloonCaption(this.txtPassword, "密码不能为空");
                DevComponents.DotNetBar.MessageBoxEx.Show("登陆名不能为空");
                return ;
            }
            Login?.Invoke( this.txtLoginName.Text, this.txtPassword.Text);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Cancel?.Invoke();
        }
    }
}
