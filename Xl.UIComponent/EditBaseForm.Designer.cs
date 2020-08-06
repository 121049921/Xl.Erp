namespace Xl.UIComponent
{
    partial class EditBaseForm
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
            this.editFormToolBar = new Xl.UIComponent.EditFormToolBar();
            this.panel = new System.Windows.Forms.Panel();
            this.layoutControl = new DevComponents.DotNetBar.Layout.LayoutControl();
            this.metroStatusBar1 = new DevComponents.DotNetBar.Metro.MetroStatusBar();
            this.balloonTip = new DevComponents.DotNetBar.BalloonTip();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // editFormToolBar
            // 
            this.editFormToolBar.DisplayEditFormToolButton = Xl.UIComponent.EditFormToolButton.btnClose;
            this.editFormToolBar.Location = new System.Drawing.Point(1, 4);
            this.editFormToolBar.Name = "editFormToolBar";
            this.editFormToolBar.Size = new System.Drawing.Size(810, 30);
            this.editFormToolBar.TabIndex = 0;
            // 
            // panel
            // 
            this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel.Controls.Add(this.layoutControl);
            this.panel.Location = new System.Drawing.Point(1, 40);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(810, 483);
            this.panel.TabIndex = 1;
            // 
            // layoutControl
            // 
            this.layoutControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.layoutControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.layoutControl.ForeColor = System.Drawing.Color.Black;
            this.layoutControl.Location = new System.Drawing.Point(11, 15);
            this.layoutControl.Name = "layoutControl";
            this.layoutControl.Size = new System.Drawing.Size(787, 456);
            this.layoutControl.TabIndex = 0;
            // 
            // metroStatusBar1
            // 
            // 
            // 
            // 
            this.metroStatusBar1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroStatusBar1.ContainerControlProcessDialogKey = true;
            this.metroStatusBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metroStatusBar1.DragDropSupport = true;
            this.metroStatusBar1.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroStatusBar1.Location = new System.Drawing.Point(0, 526);
            this.metroStatusBar1.Name = "metroStatusBar1";
            this.metroStatusBar1.Size = new System.Drawing.Size(817, 22);
            this.metroStatusBar1.TabIndex = 2;
            // 
            // EditBaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 548);
            this.Controls.Add(this.metroStatusBar1);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.editFormToolBar);
            this.Name = "EditBaseForm";
            this.Text = "编辑基类窗体";
            this.Load += new System.EventHandler(this.EditBaseForm_Load);
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevComponents.DotNetBar.Metro.MetroStatusBar metroStatusBar1;
        public EditFormToolBar editFormToolBar;
        public System.Windows.Forms.Panel panel;
        public DevComponents.DotNetBar.Layout.LayoutControl layoutControl;
        private DevComponents.DotNetBar.BalloonTip balloonTip;
    }
}