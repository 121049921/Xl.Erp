namespace Xl.Client
{
    public partial class BaseBusinessEditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseBusinessEditForm));
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // editFormToolBar
            // 
            this.editFormToolBar.Size = new System.Drawing.Size(799, 30);
            // 
            // panel
            // 
            this.panel.Size = new System.Drawing.Size(793, 385);
            // 
            // layoutControl
            // 
            this.layoutControl.Size = new System.Drawing.Size(770, 358);
            // 
            // BaseBusinessEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
           // this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BaseBusinessEditForm";
            this.Text = "BaseBusinessEditForm";
            this.Load += new System.EventHandler(this.BaseBusinessEditForm_Load);
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
    }
}