namespace Xl.Client
{
    partial class SysRoleEditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SysRoleEditForm));
            this.int_Sort = new DevComponents.Editors.IntegerInput();
            this.layoutControlItem1 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.txt_Name = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.layoutControlItem2 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.ckb_IsEable = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.layoutControlItem3 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.layoutControlItem4 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.txt_Remark = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.layoutControlItem5 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.txt_Code = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.layoutControlItem6 = new DevComponents.DotNetBar.Layout.LayoutControlItem();
            this.panel.SuspendLayout();
            this.layoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.int_Sort)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl
            // 
            this.layoutControl.Controls.Add(this.txt_Code);
            this.layoutControl.Controls.Add(this.ckb_IsEable);
            this.layoutControl.Controls.Add(this.txt_Name);
            this.layoutControl.Controls.Add(this.int_Sort);
            this.layoutControl.Controls.Add(this.txt_Remark);
            // 
            // 
            // 
            this.layoutControl.RootGroup.Items.AddRange(new DevComponents.DotNetBar.Layout.LayoutItemBase[] {
            this.layoutControlItem6,
            this.layoutControlItem2,
            this.layoutControlItem1,
            this.layoutControlItem5,
            this.layoutControlItem3});
            // 
            // int_Sort
            // 
            // 
            // 
            // 
            this.int_Sort.BackgroundStyle.Class = "DateTimeInputBackground";
            this.int_Sort.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.int_Sort.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.int_Sort.Location = new System.Drawing.Point(73, 60);
            this.int_Sort.Margin = new System.Windows.Forms.Padding(0);
            this.int_Sort.Name = "int_Sort";
            this.int_Sort.ShowUpDown = true;
            this.int_Sort.Size = new System.Drawing.Size(693, 26);
            this.int_Sort.TabIndex = 2;
            this.int_Sort.Value = 1;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.int_Sort;
            this.layoutControlItem1.Height = 34;
            this.layoutControlItem1.MinSize = new System.Drawing.Size(64, 18);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Text = "排序:";
            this.layoutControlItem1.Width = 100;
            this.layoutControlItem1.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // txt_Name
            // 
            this.txt_Name.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txt_Name.Border.Class = "TextBoxBorder";
            this.txt_Name.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_Name.DisabledBackColor = System.Drawing.Color.White;
            this.txt_Name.ForeColor = System.Drawing.Color.Black;
            this.txt_Name.Location = new System.Drawing.Point(73, 32);
            this.txt_Name.Margin = new System.Windows.Forms.Padding(0);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.PreventEnterBeep = true;
            this.txt_Name.Size = new System.Drawing.Size(693, 26);
            this.txt_Name.TabIndex = 1;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txt_Name;
            this.layoutControlItem2.Height = 28;
            this.layoutControlItem2.MinSize = new System.Drawing.Size(120, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Text = "名称:";
            this.layoutControlItem2.Width = 100;
            this.layoutControlItem2.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // ckb_IsEable
            // 
            // 
            // 
            // 
            this.ckb_IsEable.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ckb_IsEable.Checked = true;
            this.ckb_IsEable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckb_IsEable.CheckValue = "Y";
            this.ckb_IsEable.Location = new System.Drawing.Point(73, 128);
            this.ckb_IsEable.Margin = new System.Windows.Forms.Padding(0);
            this.ckb_IsEable.Name = "ckb_IsEable";
            this.ckb_IsEable.Size = new System.Drawing.Size(693, 23);
            this.ckb_IsEable.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ckb_IsEable.TabIndex = 4;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.ckb_IsEable;
            this.layoutControlItem3.Height = 31;
            this.layoutControlItem3.MinSize = new System.Drawing.Size(64, 18);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Text = "是否启用:";
            this.layoutControlItem3.Width = 100;
            this.layoutControlItem3.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.txt_Remark;
            this.layoutControlItem4.Height = 28;
            this.layoutControlItem4.MinSize = new System.Drawing.Size(120, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Text = "名称:";
            this.layoutControlItem4.Width = 100;
            this.layoutControlItem4.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // txt_Remark
            // 
            this.txt_Remark.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txt_Remark.Border.Class = "TextBoxBorder";
            this.txt_Remark.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_Remark.DisabledBackColor = System.Drawing.Color.White;
            this.txt_Remark.ForeColor = System.Drawing.Color.Black;
            this.txt_Remark.Location = new System.Drawing.Point(73, 94);
            this.txt_Remark.Margin = new System.Windows.Forms.Padding(0);
            this.txt_Remark.Name = "txt_Remark";
            this.txt_Remark.PreventEnterBeep = true;
            this.txt_Remark.Size = new System.Drawing.Size(693, 26);
            this.txt_Remark.TabIndex = 3;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.txt_Remark;
            this.layoutControlItem5.Height = 34;
            this.layoutControlItem5.MinSize = new System.Drawing.Size(120, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Text = "备注:";
            this.layoutControlItem5.Width = 100;
            this.layoutControlItem5.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // txt_Code
            // 
            this.txt_Code.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txt_Code.Border.Class = "TextBoxBorder";
            this.txt_Code.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_Code.DisabledBackColor = System.Drawing.Color.White;
            this.txt_Code.ForeColor = System.Drawing.Color.Black;
            this.txt_Code.Location = new System.Drawing.Point(73, 4);
            this.txt_Code.Margin = new System.Windows.Forms.Padding(0);
            this.txt_Code.Name = "txt_Code";
            this.txt_Code.PreventEnterBeep = true;
            this.txt_Code.Size = new System.Drawing.Size(693, 26);
            this.txt_Code.TabIndex = 0;
            this.txt_Code.WatermarkText = "自动生成";
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.txt_Code;
            this.layoutControlItem6.Height = 28;
            this.layoutControlItem6.MinSize = new System.Drawing.Size(120, 0);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Text = "编码:";
            this.layoutControlItem6.Width = 100;
            this.layoutControlItem6.WidthType = DevComponents.DotNetBar.Layout.eLayoutSizeType.Percent;
            // 
            // SysRoleEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SysRoleEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SysRoleEditForm";
            this.panel.ResumeLayout(false);
            this.layoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.int_Sort)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.Editors.IntegerInput int_Sort;
        private DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem1;
        private DevComponents.DotNetBar.Controls.CheckBoxX ckb_IsEable;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_Name;
        private DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem2;
        private DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem3;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_Remark;
        private DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem5;
        private DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem4;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_Code;
        private DevComponents.DotNetBar.Layout.LayoutControlItem layoutControlItem6;
    }
}