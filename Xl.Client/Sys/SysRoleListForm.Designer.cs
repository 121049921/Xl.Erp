namespace Xl.Client
{
    partial class SysRoleListForm
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
            this.listFormToolBar.Size = new System.Drawing.Size(793, 33);
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(793, 370);
            // 
            // superGrid
            // 
            this.superGrid.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed;
            // 
            // 
            // 
            this.superGrid.PrimaryGrid.AllowRowDelete = true;
            this.superGrid.PrimaryGrid.GridLines = DevComponents.DotNetBar.SuperGrid.GridLines.Horizontal;
            this.superGrid.PrimaryGrid.SelectionGranularity = DevComponents.DotNetBar.SuperGrid.SelectionGranularity.Row;
            this.superGrid.PrimaryGrid.ShowTreeButtons = true;
            this.superGrid.PrimaryGrid.ShowTreeLines = true;
            this.superGrid.PrimaryGrid.UseAlternateColumnStyle = true;
            this.superGrid.PrimaryGrid.UseAlternateRowStyle = true;
            this.superGrid.Size = new System.Drawing.Size(793, 370);
            // 
            // pageToolBar
            // 
            this.pageToolBar.Location = new System.Drawing.Point(3, 413);
            this.pageToolBar.Size = new System.Drawing.Size(793, 30);
            // 
            // SysRoleListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "SysRoleListForm";
            this.Text = "";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}