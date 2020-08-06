namespace Xl.UIComponent
{
    partial class ListBaseForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listFormToolBar = new Xl.UIComponent.ListFormToolBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.superGrid = new DevComponents.DotNetBar.SuperGrid.SuperGridControl();
            this.pageToolBar = new Xl.UIComponent.PageToolBar();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listFormToolBar
            // 
            this.listFormToolBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listFormToolBar.AutoScroll = true;
            this.listFormToolBar.Location = new System.Drawing.Point(3, 2);
            this.listFormToolBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listFormToolBar.Name = "listFormToolBar";
            this.listFormToolBar.Size = new System.Drawing.Size(907, 33);
            this.listFormToolBar.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.superGrid);
            this.panel1.Location = new System.Drawing.Point(3, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(907, 468);
            this.panel1.TabIndex = 1;
            // 
            // superGrid
            // 
            this.superGrid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.superGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superGrid.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed;
            this.superGrid.ForeColor = System.Drawing.Color.Black;
            this.superGrid.Location = new System.Drawing.Point(0, 0);
            this.superGrid.Name = "superGrid";
            // 
            // 
            // 
            this.superGrid.PrimaryGrid.AllowRowDelete = true;
            this.superGrid.PrimaryGrid.SelectionGranularity = DevComponents.DotNetBar.SuperGrid.SelectionGranularity.Row;
            this.superGrid.PrimaryGrid.ShowTreeButtons = true;
            this.superGrid.PrimaryGrid.ShowTreeLines = true;
            this.superGrid.PrimaryGrid.UseAlternateColumnStyle = true;
            this.superGrid.PrimaryGrid.UseAlternateRowStyle = true;
            this.superGrid.Size = new System.Drawing.Size(907, 468);
            this.superGrid.TabIndex = 0;
            this.superGrid.Text = "superGrid";
            this.superGrid.Click += new System.EventHandler(this.superGrid_Click);
            // 
            // pageToolBar
            // 
            this.pageToolBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pageToolBar.Location = new System.Drawing.Point(3, 511);
            this.pageToolBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pageToolBar.Name = "pageToolBar";
            this.pageToolBar.Size = new System.Drawing.Size(907, 30);
            this.pageToolBar.TabIndex = 2;
            // 
            // ListBaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 548);
            this.Controls.Add(this.pageToolBar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listFormToolBar);
            this.Name = "ListBaseForm";
            this.Text = "列表基类窗体";
            this.Load += new System.EventHandler(this.ListBaseForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public ListFormToolBar listFormToolBar;
        public System.Windows.Forms.Panel panel1;
        public DevComponents.DotNetBar.SuperGrid.SuperGridControl superGrid;
        public PageToolBar pageToolBar;
    }
}
