using DevComponents.DotNetBar;
using Newtonsoft.Json;
using ServiceStack;
using ServiceStack.Redis;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xl.Common;
using Xl.Model;
using Xl.UIComponent;

namespace Xl.Client
{
    public partial class LoginForm : BaseForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {


            this.loginUI.Login += LoginUI_Login;
            this.loginUI.Cancel += LoginUI_Cancel;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="loginName"></param>
        /// <param name="password"></param>
        private void LoginUI_Login(string loginName, string password)
        {

            if (loginName=="admin")
            {
                //null != GetSysUser()
                // SetSysUserCache();
                this.DialogResult = DialogResult.OK;

            }
            else
            {
                MessageBoxEx.Show("用户名或密码不正确");
                this.DialogResult = DialogResult.No;
            }
        }

        private SysUser GetSysUser()
        {
            using (var redis = new RedisClient("127.0.0.1", 6379))//不用密码登陆测试
            {
                var sysUser = redis.Get<SysUser>(nameof(SysUser));
                if (sysUser == null)
                {
                    sysUser = new SysUser { LoginName = "amdin", Password = "123456" };
                    redis.Set<SysUser>(nameof(sysUser), sysUser);
                }
                return sysUser;
            }
        }

        private void SetSysUserCache()
        {
            List<SysUser> sysUsers = new List<SysUser>();
            for (int i = 0; i < 1000; i++)
            {
                var user = new SysUser() { LoginName = "amdin" + i, Password = "123456" };
                sysUsers.Add(user);
            }

            //大数据时,用has存
            using (var redis = new RedisClient("127.0.0.1", 6379))//不用密码登陆测试
            {
                redis.SetEntryInHash(typeof(SysUser).FullName.Replace(".", ":"), nameof(SysUser), JsonConvert.SerializeObject(sysUsers));
            }

        }
        private void LoginUI_Cancel()
        {
            this.Close();
        }

        /// <summary>
        /// 更新版本
        /// </summary>
        private void UpdateVersion()
        {
            AppVersion appVersion = LiteDbHelper.Instanc.FindOne<AppVersion>();
            if (appVersion == null)
            {
                //取务端最新的
            }
            else
            {
                //取务端最新的和和目前客户版本对比,大于客户端版本,更新下载
            }

        }
    }
}
