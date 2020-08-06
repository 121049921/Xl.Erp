using DevComponents.DotNetBar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Xl.UIComponent
{
    public partial class CommonBaseForm :  Xl.UIComponent.BaseForm
    {
        
        private SuperTabItem parentTabItem;
        /// <summary>
        /// 父类Tab
        /// </summary>
        protected DevComponents.DotNetBar.SuperTabControl TabMain;
        #region 窗体打开
        /// <summary>
        /// 窗体打开
        /// </summary>
        /// <param name="tab">要打开到的TabControl</param>
        /// <param name="caption">标题</param>
        /// <param name="allowDuplicate">是否允许打开多个</param>
        public virtual void ShowAsTabPage(SuperTabControl tabMain, bool allowDuplicate = false, string caption = "")
        {
            caption = string.IsNullOrEmpty(caption) ? this.Text : caption;
            this.TabMain = tabMain;
            if (allowDuplicate)
            {
                OpenTabPage(tabMain, caption);
            }
            else
            {
                bool IsOpened = false;
                foreach (SuperTabItem tabitem in tabMain.Tabs)
                {
                    if (tabitem.AttachedControl.Controls.Count > 0)
                    {
                        if (tabitem.AttachedControl.Controls[0].GetType() == this.GetType() && tabitem.Text.Equals(caption))
                        {
                            tabMain.SelectedTab = tabitem;
                            ((CommonBaseForm)tabitem.AttachedControl.Controls[0]).OnActivated(new EventArgs());
                            IsOpened = true;
                            break;
                        }
                    }

                }
                if (!IsOpened)
                {
                    OpenTabPage(tabMain, caption);
                }
            }
            this.Select();
            tabMain.SelectedTabChanged += tab_SelectedTabChanged;
        }
        private void tab_SelectedTabChanged(object sender, SuperTabStripSelectedTabChangedEventArgs e)
        {
            if (TabMain != null && TabMain.Tabs.Count > 1 && TabMain.SelectedTab != null)
            {
                if (TabMain.SelectedTab.AttachedControl.Controls.Count > 0)
                {
                    if (TabMain.SelectedTab.AttachedControl.Controls[0] is ListBaseForm)
                    {
                        ((ListBaseForm)TabMain.SelectedTab.AttachedControl.Controls[0]).Activate();
                    }
                    else
                    {
                        //((ListBaseForm)TabMain.SelectedTab.AttachedControl.Controls[0]).Activate();
                    }
                }
            }
        }
        /// <summary>
        /// 在指定的的TabControl中显示窗体
        /// </summary>
        /// <param name="tab">TabControl</param>
        /// <param name="caption">标题</param>
        private void OpenTabPage(SuperTabControl tab, string caption)
        {
            FormBorderStyle = FormBorderStyle.None;
            TopLevel = false;
            Visible = true;
            Dock = DockStyle.Fill;
            parentTabItem = tab.CreateTab(caption);
            parentTabItem.Name = caption;
            parentTabItem.Text = caption;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.TopLevel = false;
            this.Visible = true;
            this.Dock = System.Windows.Forms.DockStyle.Fill;
            parentTabItem.AttachedControl.Controls.Add(this);
            tab.SelectedTab = parentTabItem;
            TabMain = tab;
        }
        private void OpenTabPage(SuperTabControl tab, string caption, Image image)
        {
            parentTabItem = tab.CreateTab(caption);
            parentTabItem.Name = caption;
            parentTabItem.Text = caption;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.TopLevel = false;
            this.Visible = true;
            this.Dock = System.Windows.Forms.DockStyle.Fill;
            parentTabItem.AttachedControl.Controls.Add(this);
            tab.SelectedTab = parentTabItem;
            TabMain = tab;
        }
        #endregion

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // CommonBaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(581, 485);
            this.Name = "CommonBaseForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }
    }
}
