namespace Xl.UIComponent
{
    partial class PageToolBar
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
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.bar = new DevComponents.DotNetBar.Bar();
            this.cmbPageSize = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.lbTip = new DevComponents.DotNetBar.LabelItem();
            this.lbPage = new DevComponents.DotNetBar.LabelItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPrex = new DevComponents.DotNetBar.ButtonItem();
            this.btnNext = new DevComponents.DotNetBar.ButtonItem();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bar)).BeginInit();
            this.bar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Metro;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))), System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199))))));
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.bar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(835, 27);
            this.panel2.TabIndex = 1;
            // 
            // bar
            // 
            this.bar.AntiAlias = true;
            this.bar.BackColor = System.Drawing.Color.White;
            this.bar.Controls.Add(this.cmbPageSize);
            this.bar.DockSide = DevComponents.DotNetBar.eDockSide.Document;
            this.bar.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.bar.IsMaximized = false;
            this.bar.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.lbTip,
            this.lbPage,
            this.btnPrex,
            this.btnNext});
            this.bar.Location = new System.Drawing.Point(3, 3);
            this.bar.Name = "bar";
            this.bar.Size = new System.Drawing.Size(829, 30);
            this.bar.Stretch = true;
            this.bar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bar.TabIndex = 0;
            this.bar.TabStop = false;
            this.bar.Text = "bar";
            // 
            // cmbPageSize
            // 
            this.cmbPageSize.DisplayMember = "Text";
            this.cmbPageSize.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbPageSize.ForeColor = System.Drawing.Color.Black;
            this.cmbPageSize.FormattingEnabled = true;
            this.cmbPageSize.ItemHeight = 18;
            this.cmbPageSize.Location = new System.Drawing.Point(259, 0);
            this.cmbPageSize.Name = "cmbPageSize";
            this.cmbPageSize.Size = new System.Drawing.Size(56, 24);
            this.cmbPageSize.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmbPageSize.TabIndex = 0;
            this.cmbPageSize.SelectedIndexChanged += new System.EventHandler(this.cmbPageSize_SelectedIndexChanged);
            // 
            // lbTip
            // 
            this.lbTip.ForeColor = System.Drawing.Color.Red;
            this.lbTip.Name = "lbTip";
            // 
            // lbPage
            // 
            this.lbPage.Name = "lbPage";
            this.lbPage.Symbol = "";
            this.lbPage.SymbolColor = System.Drawing.Color.DodgerBlue;
            this.lbPage.Text = "第{0}页,  共{1}页,  数据{2}条";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(835, 27);
            this.panel1.TabIndex = 2;
            // 
            // btnPrex
            // 
            this.btnPrex.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnPrex.Image = global::Xl.UIComponent.Properties.Resources.首张;
            this.btnPrex.Name = "btnPrex";
            this.btnPrex.Tooltip = "上一页";
            this.btnPrex.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnNext.Image = global::Xl.UIComponent.Properties.Resources.末张;
            this.btnNext.Name = "btnNext";
            this.btnNext.Tooltip = "下一页";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // PageToolBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "PageToolBar";
            this.Size = new System.Drawing.Size(835, 27);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bar)).EndInit();
            this.bar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
    
        private DevComponents.DotNetBar.StyleManager styleManager1;
        private DevComponents.DotNetBar.ButtonItem btnPrex;
        private System.Windows.Forms.Panel panel2;
        private DevComponents.DotNetBar.ButtonItem btnNext;
        private System.Windows.Forms.Panel panel1;
        public DevComponents.DotNetBar.Bar bar;
        private DevComponents.DotNetBar.LabelItem lbPage;
        private DevComponents.DotNetBar.LabelItem lbTip;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbPageSize;
    }
}
