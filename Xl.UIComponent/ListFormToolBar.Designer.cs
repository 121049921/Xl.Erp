namespace Xl.UIComponent
{
    partial class ListFormToolBar
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bar = new DevComponents.DotNetBar.Bar();
            this.btnAdd = new DevComponents.DotNetBar.ButtonItem();
            this.btnEdit = new DevComponents.DotNetBar.ButtonItem();
            this.btnDelete = new DevComponents.DotNetBar.ButtonItem();
            this.btnAudit = new DevComponents.DotNetBar.ButtonItem();
            this.btnUnAudit = new DevComponents.DotNetBar.ButtonItem();
            this.btnResume = new DevComponents.DotNetBar.ButtonItem();
            this.btnSuspend = new DevComponents.DotNetBar.ButtonItem();
            this.txtSearchKey = new DevComponents.DotNetBar.TextBoxItem();
            this.btnSearch = new DevComponents.DotNetBar.ButtonItem();
            this.btnAdvSearch = new DevComponents.DotNetBar.ButtonItem();
            this.btnPrint = new DevComponents.DotNetBar.ButtonItem();
            this.btnExport = new DevComponents.DotNetBar.ButtonItem();
            this.btnClose = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem2 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem4 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem5 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem3 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem1 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem8 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem9 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem10 = new DevComponents.DotNetBar.ButtonItem();
            this.flyout1 = new DevComponents.DotNetBar.Controls.Flyout(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(834, 31);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.bar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(834, 31);
            this.panel2.TabIndex = 1;
            // 
            // bar
            // 
            this.bar.AntiAlias = true;
            this.bar.BackColor = System.Drawing.Color.White;
            this.bar.DockSide = DevComponents.DotNetBar.eDockSide.Document;
            this.bar.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.bar.IsMaximized = false;
            this.bar.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnAdd,
            this.btnEdit,
            this.btnDelete,
            this.btnAudit,
            this.btnUnAudit,
            this.btnResume,
            this.btnSuspend,
            this.txtSearchKey,
            this.btnSearch,
            this.btnPrint,
            this.btnExport,
            this.btnClose});
            this.bar.Location = new System.Drawing.Point(3, 3);
            this.bar.Name = "bar";
            this.bar.Size = new System.Drawing.Size(831, 26);
            this.bar.Stretch = true;
            this.bar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bar.TabIndex = 0;
            this.bar.TabStop = false;
            this.bar.Text = "bar2";
            // 
            // btnAdd
            // 
            this.btnAdd.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnAdd.Image = global::Xl.UIComponent.Properties.Resources.application_add;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Text = "新增";
            this.btnAdd.Tooltip = "新增";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnEdit.Image = global::Xl.UIComponent.Properties.Resources.application_edit;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Text = "编辑";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnDelete.Image = global::Xl.UIComponent.Properties.Resources.delete;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Text = "删除";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAudit
            // 
            this.btnAudit.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnAudit.Image = global::Xl.UIComponent.Properties.Resources.审核;
            this.btnAudit.Name = "btnAudit";
            this.btnAudit.Text = "审核";
            this.btnAudit.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnUnAudit
            // 
            this.btnUnAudit.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnUnAudit.Image = global::Xl.UIComponent.Properties.Resources.反审;
            this.btnUnAudit.Name = "btnUnAudit";
            this.btnUnAudit.Text = "反审";
            // 
            // btnResume
            // 
            this.btnResume.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnResume.Image = global::Xl.UIComponent.Properties.Resources.启用;
            this.btnResume.Name = "btnResume";
            this.btnResume.Text = "启用";
            // 
            // btnSuspend
            // 
            this.btnSuspend.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnSuspend.Image = global::Xl.UIComponent.Properties.Resources.暂停;
            this.btnSuspend.Name = "btnSuspend";
            this.btnSuspend.Text = "暂停";
            // 
            // txtSearchKey
            // 
            this.txtSearchKey.Name = "txtSearchKey";
            this.txtSearchKey.TextBoxHeight = 15;
            this.txtSearchKey.TextBoxWidth = 180;
            this.txtSearchKey.Tooltip = "查询关健字";
            this.txtSearchKey.WatermarkColor = System.Drawing.SystemColors.GrayText;
            this.txtSearchKey.WatermarkFont = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtSearchKey.WatermarkImageAlignment = System.Drawing.ContentAlignment.BottomLeft;
            this.txtSearchKey.WatermarkText = "查询关健字";
            // 
            // btnSearch
            // 
            this.btnSearch.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnSearch.Image = global::Xl.UIComponent.Properties.Resources.查询;
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnAdvSearch});
            this.btnSearch.Text = "查询";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnAdvSearch
            // 
            this.btnAdvSearch.Image = global::Xl.UIComponent.Properties.Resources.zoom_in;
            this.btnAdvSearch.Name = "btnAdvSearch";
            this.btnAdvSearch.Text = "高级查询";
            this.btnAdvSearch.Click += new System.EventHandler(this.btnAdvSearch_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnPrint.Image = global::Xl.UIComponent.Properties.Resources.printer_empty;
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Text = "打印";
            // 
            // btnExport
            // 
            this.btnExport.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnExport.Image = global::Xl.UIComponent.Properties.Resources.page_white_excel;
            this.btnExport.Name = "btnExport";
            this.btnExport.Text = "导出";
            // 
            // btnClose
            // 
            this.btnClose.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnClose.Image = global::Xl.UIComponent.Properties.Resources.cross;
            this.btnClose.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Center;
            this.btnClose.Name = "btnClose";
            this.btnClose.Text = "关闭";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // buttonItem2
            // 
            this.buttonItem2.Name = "buttonItem2";
            // 
            // buttonItem4
            // 
            this.buttonItem4.Name = "buttonItem4";
            // 
            // buttonItem5
            // 
            this.buttonItem5.Name = "buttonItem5";
            // 
            // buttonItem3
            // 
            this.buttonItem3.Name = "buttonItem3";
            // 
            // buttonItem1
            // 
            this.buttonItem1.Name = "buttonItem1";
            // 
            // buttonItem8
            // 
            this.buttonItem8.Name = "buttonItem8";
            // 
            // buttonItem9
            // 
            this.buttonItem9.Name = "buttonItem9";
            // 
            // buttonItem10
            // 
            this.buttonItem10.Name = "buttonItem10";
            // 
            // flyout1
            // 
            this.flyout1.DropShadow = false;
            this.flyout1.Parent = this;
            // 
            // ListFormToolBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "ListFormToolBar";
            this.Size = new System.Drawing.Size(834, 31);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private DevComponents.DotNetBar.ButtonItem buttonItem2;
        private DevComponents.DotNetBar.ButtonItem buttonItem4;
        private DevComponents.DotNetBar.ButtonItem buttonItem5;
        private DevComponents.DotNetBar.ButtonItem buttonItem3;
        private DevComponents.DotNetBar.ButtonItem buttonItem1;
        private DevComponents.DotNetBar.ButtonItem buttonItem8;
        private DevComponents.DotNetBar.ButtonItem buttonItem9;
        private DevComponents.DotNetBar.ButtonItem buttonItem10;
        private System.Windows.Forms.Panel panel2;
        private DevComponents.DotNetBar.Bar bar;
        private DevComponents.DotNetBar.ButtonItem btnAdd;
        private DevComponents.DotNetBar.ButtonItem btnEdit;
        private DevComponents.DotNetBar.ButtonItem btnDelete;
        private DevComponents.DotNetBar.ButtonItem btnClose;
        private DevComponents.DotNetBar.ButtonItem btnAudit;
        private DevComponents.DotNetBar.ButtonItem btnUnAudit;
        private DevComponents.DotNetBar.ButtonItem btnResume;
        private DevComponents.DotNetBar.ButtonItem btnSuspend;
        private DevComponents.DotNetBar.TextBoxItem txtSearchKey;
        private DevComponents.DotNetBar.ButtonItem btnSearch;
        private DevComponents.DotNetBar.Controls.Flyout flyout1;
        private DevComponents.DotNetBar.ButtonItem btnAdvSearch;
        private DevComponents.DotNetBar.ButtonItem btnPrint;
        private DevComponents.DotNetBar.ButtonItem btnExport;
    }
}
