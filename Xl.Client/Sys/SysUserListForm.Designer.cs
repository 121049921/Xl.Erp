namespace Xl.Client
{
    partial class SysUserListForm
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
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listFormToolBar
            // 
            this.listFormToolBar.Size = new System.Drawing.Size(892, 32);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(3, 55);
            this.panel1.Size = new System.Drawing.Size(892, 518);
            // 
            // superGrid
            // 
            this.superGrid.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed;
            // 
            // 
            // 
            this.superGrid.PrimaryGrid.AllowRowDelete = true;
            this.superGrid.PrimaryGrid.AllowRowInsert = true;
            this.superGrid.PrimaryGrid.ColumnAutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.Fill;
            this.superGrid.PrimaryGrid.DefaultVisualStyles.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter;
            this.superGrid.PrimaryGrid.GridLines = DevComponents.DotNetBar.SuperGrid.GridLines.Horizontal;
            this.superGrid.PrimaryGrid.InitialSelection = DevComponents.DotNetBar.SuperGrid.RelativeSelection.Row;
            this.superGrid.PrimaryGrid.MultiSelect = false;
            this.superGrid.PrimaryGrid.SelectionGranularity = DevComponents.DotNetBar.SuperGrid.SelectionGranularity.Row;
            this.superGrid.PrimaryGrid.ShowInsertRow = true;
            this.superGrid.PrimaryGrid.ShowRowHeaders = false;
            this.superGrid.PrimaryGrid.ShowTreeButtons = true;
            this.superGrid.PrimaryGrid.ShowTreeLines = true;
            this.superGrid.PrimaryGrid.UseAlternateColumnStyle = true;
            this.superGrid.PrimaryGrid.UseAlternateRowStyle = true;
            this.superGrid.Size = new System.Drawing.Size(892, 518);
            // 
            // pageToolBar
            // 
            this.pageToolBar.Location = new System.Drawing.Point(3, 574);
            this.pageToolBar.Size = new System.Drawing.Size(892, 30);
            // 
            // SysUserListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 604);
            this.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.Name = "SysUserListForm";
            this.Text = "";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}