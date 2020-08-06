namespace Xl.UIComponent
{
    partial class LoginUI
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
            this.panel = new System.Windows.Forms.Panel();
            this.txtPassword = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtLoginName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.btnLogin = new DevComponents.DotNetBar.ButtonX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.sbPasswrod = new DevComponents.DotNetBar.Controls.SymbolBox();
            this.lbLoginName = new DevComponents.DotNetBar.LabelX();
            this.sbLoginName = new DevComponents.DotNetBar.Controls.SymbolBox();
            this.balloonTip = new DevComponents.DotNetBar.BalloonTip();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel.Controls.Add(this.txtPassword);
            this.panel.Controls.Add(this.txtLoginName);
            this.panel.Controls.Add(this.btnCancel);
            this.panel.Controls.Add(this.btnLogin);
            this.panel.Controls.Add(this.labelX1);
            this.panel.Controls.Add(this.sbPasswrod);
            this.panel.Controls.Add(this.lbLoginName);
            this.panel.Controls.Add(this.sbLoginName);
            this.panel.Location = new System.Drawing.Point(0, 3);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(425, 217);
            this.panel.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtPassword.Border.Class = "TextBoxBorder";
            this.txtPassword.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPassword.DisabledBackColor = System.Drawing.Color.White;
            this.txtPassword.ForeColor = System.Drawing.Color.Black;
            this.txtPassword.Location = new System.Drawing.Point(151, 85);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PreventEnterBeep = true;
            this.txtPassword.Size = new System.Drawing.Size(211, 21);
            this.txtPassword.TabIndex = 25;
            this.txtPassword.Text = "123456";
            // 
            // txtLoginName
            // 
            this.txtLoginName.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtLoginName.Border.Class = "TextBoxBorder";
            this.txtLoginName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtLoginName.DisabledBackColor = System.Drawing.Color.White;
            this.txtLoginName.ForeColor = System.Drawing.Color.Black;
            this.txtLoginName.Location = new System.Drawing.Point(151, 55);
            this.txtLoginName.Name = "txtLoginName";
            this.txtLoginName.PreventEnterBeep = true;
            this.txtLoginName.Size = new System.Drawing.Size(211, 21);
            this.txtLoginName.TabIndex = 24;
            this.txtLoginName.Text = "admin";
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancel.Image = global::Xl.UIComponent.Properties.Resources.vcard_delete;
            this.btnCancel.Location = new System.Drawing.Point(274, 121);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(88, 36);
            this.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancel.TabIndex = 23;
            this.btnCancel.Text = "退出";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnLogin.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnLogin.Image = global::Xl.UIComponent.Properties.Resources.user_add;
            this.btnLogin.Location = new System.Drawing.Point(151, 121);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(96, 36);
            this.btnLogin.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnLogin.TabIndex = 22;
            this.btnLogin.Text = "登陆";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelX1.Location = new System.Drawing.Point(80, 85);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(36, 23);
            this.labelX1.TabIndex = 21;
            this.labelX1.Text = "密码:";
            // 
            // sbPasswrod
            // 
            // 
            // 
            // 
            this.sbPasswrod.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.sbPasswrod.ForeColor = System.Drawing.SystemColors.Highlight;
            this.sbPasswrod.Location = new System.Drawing.Point(122, 85);
            this.sbPasswrod.Name = "sbPasswrod";
            this.sbPasswrod.Size = new System.Drawing.Size(23, 23);
            this.sbPasswrod.Symbol = "";
            this.sbPasswrod.TabIndex = 19;
            this.sbPasswrod.Text = "sbPasswrod";
            // 
            // lbLoginName
            // 
            // 
            // 
            // 
            this.lbLoginName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbLoginName.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbLoginName.Location = new System.Drawing.Point(68, 54);
            this.lbLoginName.Name = "lbLoginName";
            this.lbLoginName.Size = new System.Drawing.Size(48, 23);
            this.lbLoginName.TabIndex = 18;
            this.lbLoginName.Text = "用户名:";
            // 
            // sbLoginName
            // 
            // 
            // 
            // 
            this.sbLoginName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.sbLoginName.ForeColor = System.Drawing.SystemColors.Highlight;
            this.sbLoginName.Location = new System.Drawing.Point(122, 54);
            this.sbLoginName.Name = "sbLoginName";
            this.sbLoginName.Size = new System.Drawing.Size(23, 23);
            this.sbLoginName.Symbol = "";
            this.sbLoginName.TabIndex = 16;
            this.sbLoginName.Text = "sbLoginName";
            // 
            // LoginUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel);
            this.Name = "LoginUI";
            this.Size = new System.Drawing.Size(428, 223);
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private DevComponents.DotNetBar.ButtonX btnCancel;
        private DevComponents.DotNetBar.ButtonX btnLogin;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.SymbolBox sbPasswrod;
        private DevComponents.DotNetBar.LabelX lbLoginName;
        private DevComponents.DotNetBar.Controls.SymbolBox sbLoginName;
        private DevComponents.DotNetBar.BalloonTip balloonTip;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPassword;
        private DevComponents.DotNetBar.Controls.TextBoxX txtLoginName;
    }
}
