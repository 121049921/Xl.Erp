using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xl.Client.Bs;

namespace Xl.Client
{
    public partial class MainForm : DevComponents.DotNetBar.Office2007Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {

        }
        private void Role_Click(object sender, EventArgs e)
        {
            DevComponents.DotNetBar.ButtonItem button = sender as DevComponents.DotNetBar.ButtonItem;
            SysRoleListForm form = new SysRoleListForm();
            form.ShowAsTabPage(superTabControl, false, button.Text);
        }

        private void User_Click(object sender, EventArgs e)
        {
            DevComponents.DotNetBar.ButtonItem button = sender as DevComponents.DotNetBar.ButtonItem;
            SysUserListForm form = new SysUserListForm();
            form.ShowAsTabPage(superTabControl, false, button.Text);
        }

        private void Menu_Click(object sender, EventArgs e)
        {
            //DevComponents.DotNetBar.ButtonItem button = sender as DevComponents.DotNetBar.ButtonItem;
            //SysMenuListForm form = new SysMenuListForm();
            //form.ShowAsTabPage(superTabControl, false, button.Text);

        }

        private void Button_Click(object sender, EventArgs e)
        {
            //DevComponents.DotNetBar.ButtonItem button = sender as DevComponents.DotNetBar.ButtonItem;
            //SysButtonListForm form = new SysButtonListForm();
            //form.ShowAsTabPage(superTabControl, false, button.Text);
        }

        private void Position_Click(object sender, EventArgs e)
        {
            //DevComponents.DotNetBar.ButtonItem button = sender as DevComponents.DotNetBar.ButtonItem;
            //SysPositionListForm form = new SysPositionListForm();
            //form.ShowAsTabPage(superTabControl, false, button.Text);
        }

        private void Organization_Click(object sender, EventArgs e)
        {
            //DevComponents.DotNetBar.ButtonItem button = sender as DevComponents.DotNetBar.ButtonItem;
            //SysOrganizationListForm form = new SysOrganizationListForm();
            //form.ShowAsTabPage(superTabControl, false, button.Text);

        }

        private void IM_Click(object sender, EventArgs e)
        {

        }

        private void RepairOrder_Click(object sender, EventArgs e)
        {
            DevComponents.DotNetBar.ButtonItem button = sender as DevComponents.DotNetBar.ButtonItem;
            var  form = new RepairOrderListForm();
            form.ShowAsTabPage(superTabControl, false, button.Text);
        }
    }
}
