using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using DevComponents.DotNetBar.Layout;
using DevComponents.Editors;
using DevComponents.Editors.DateTimeAdv;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Xl.UIComponent
{
    public partial class EditBaseForm : BaseForm
    {
        /// <summary>
        /// 是否新增
        /// </summary>
        public bool IsAdd = true;
        /// <summary>
        /// Id
        /// </summary>
        public int Id = 0;
        /// <summary>
        /// 自定义数据
        /// </summary>
        public object Data = null;

        /// <summary>
        /// 操作的实体类
        /// </summary>
        protected virtual Type EntityType { get; }
        public EditBaseForm()
        {
            InitializeComponent();

            this.editFormToolBar.CloseClick += EditFormToolBar_CloseClick;
            this.editFormToolBar.SaveClick += EditFormToolBar_SaveClick;
            this.editFormToolBar.SaveAndNewClick += EditFormToolBar_SaveAndNewClick;

        }
        private void EditBaseForm_Load(object sender, EventArgs e)
        {
            if (!DesignMode)//一定要加这句话,要不然子窗体有时候哪个对象为空的,窗体加载不出来
            {

                OnFormLoading();
                OnBindDataToControls();
                OnFormLoadAfter();
            }
        }


        #region 加载窗体

        protected virtual void OnFormLoading()
        {
            GetControls(panel);

        }
        protected virtual void OnBindDataToControls()
        {




        }
        /// <summary>
        /// 加载完成之后
        /// </summary>
        protected virtual void OnFormLoadAfter()
        {




        }
        #endregion

        #region 设置值到控件上
        /// <summary>
        /// 编辑页调用
        /// </summary>
        protected void SetValueToControls()
        {
            object instance = Activator.CreateInstance(this.EntityType);
            foreach (var control in this.Controls)
            {
                if (control is Panel)
                {
                    Control panel = (Panel)control;
                    SetValueToControls(panel, instance);
                }
            }

        }
        protected void SetValueToControls(Control control, object entitInstance)
        {
            foreach (Control ctrl in control.Controls)
            {
                if (ctrl is Panel)
                {
                    if (ctrl.Controls.Count > 0)
                    {
                        SetValueToControls(ctrl, entitInstance);
                    }
                }
                if (ctrl is LayoutControl)
                {
                    if (ctrl.Controls.Count > 0)
                    {
                        SetValueToControls(ctrl, entitInstance);
                    }
                }
                else if (ctrl is TextBoxX)
                {

                    var key = GetRuleName(ctrl.Name);
                    if (ctrl is TextBoxX)
                    {
                        TextBoxX textBox = ctrl as TextBoxX;
                        var controlName = GetRuleName(textBox.Name);
                        if (controlName.Equals("Code"))
                        {
                            textBox.ReadOnly = true;
                            textBox.WatermarkText = string.Empty;

                        }
                    }
                    var p = EntityType.GetProperty(key);
                    ctrl.Text = p.GetValue(entitInstance)?.ToString();

                }
                else if (ctrl is IntegerInput)
                {
                    var key = GetRuleName(ctrl.Name);
                    var p = EntityType.GetProperty(key);
                    (ctrl as IntegerInput).Value = (int)p.GetValue(entitInstance);
                }
                else if (ctrl is DateTimeInput)
                {
                    var key = GetRuleName(ctrl.Name);
                    var p = EntityType.GetProperty(key);
                    (ctrl as DateTimeInput).Value = (DateTime)p.GetValue(entitInstance);
                }
                else if (ctrl is CheckBoxX)
                {
                    var key = GetRuleName(ctrl.Name);
                    var p = EntityType.GetProperty(key);
                    (ctrl as CheckBoxX).Checked = (bool)p.GetValue(entitInstance);
                }
                //类型未判断完
            }
        }

        #region 设置code
        /// <summary>
        /// 新增时调用,设置默认值等
        /// </summary>
        protected virtual void SetDefaulCodeToControls(string controlName, object value)
        {
            foreach (var control in this.Controls)
            {
                if (control is Panel)
                {
                    Control panel = (Panel)control;
                    SetDefaulCodeToControls(panel, controlName, value);
                }
            }
        }

        #endregion
        /// <summary>
        /// 设置默认值
        /// </summary>
        /// <param name="control"></param>

        public virtual void SetDefaulCodeToControls(Control control, string controlName, object value)
        {
            foreach (Control ctrl in control.Controls)
            {
                if (ctrl is Panel)
                {
                    if (ctrl.Controls.Count > 0)
                    {
                        SetDefaulCodeToControls(ctrl, controlName, value);
                    }
                }
                if (ctrl is LayoutControl)
                {
                    if (ctrl.Controls.Count > 0)
                    {
                        SetDefaulCodeToControls(ctrl, controlName, value);
                    }
                }
                else if (ctrl is TextBox)
                {
                    var key = GetRuleName(ctrl.Name);
                    if (ctrl is TextBoxX)
                    {
                        TextBoxX textBox = ctrl as TextBoxX;
                        var controllerName = GetRuleName(textBox.Name);
                        if (controllerName.Equals(controlName))
                        {
                            textBox.Text = value.ToString();
                        }
                    }
                }
                else if (ctrl is DateTimeInput)//默认时间
                {

                    DateTimeInput input = (ctrl as DateTimeInput);
                    input.Value = DateTime.Now;
                }
                else if (ctrl is CheckBoxX)//默认选中
                {

                    (ctrl as CheckBoxX).Checked = true;

                }
                else if (ctrl is IntegerInput)
                {
                    (ctrl as IntegerInput).Value = 1;
                }
                else if (ctrl is DoubleInput)
                {
                    (ctrl as DoubleInput).Value = 1;
                }
            }
        }

        /// <summary>
        /// 新增时调用,设置默认值等,如时间,数字框
        /// </summary>
        protected virtual void SetDefaultValueToControls()
        {
            foreach (var control in this.Controls)
            {
                if (control is Panel)
                {
                    Control panel = (Panel)control;
                    SetDefaultValueToControls(panel);
                }
            }
        }

        /// <summary>
        /// 设置默认值
        /// </summary>
        /// <param name="control"></param>

        public virtual void SetDefaultValueToControls(Control control)
        {
            foreach (Control ctrl in control.Controls)
            {
                if (ctrl is Panel)
                {
                    if (ctrl.Controls.Count > 0)
                    {
                        SetDefaultValueToControls(ctrl);
                    }
                }
                if (ctrl is LayoutControl)
                {
                    if (ctrl.Controls.Count > 0)
                    {
                        SetDefaultValueToControls(ctrl);
                    }
                }
                else if (ctrl is TextBox)
                {

                    if (ctrl is TextBoxX)
                    {
                        TextBoxX textBox = ctrl as TextBoxX;
                        var controlName = GetRuleName(textBox.Name);
                        if (controlName.Equals("Code"))
                        {
                            textBox.ReadOnly = true;
                            textBox.ForeColor = Color.Red;
                            if (Id <= 0)
                            {
                                textBox.WatermarkText = GlobleParamters.DefaultCode;
                                textBox.Text = GlobleParamters.DefaultCode;
                            }
                        }
                    }
                }
                else if (ctrl is DateTimeInput)//默认时间
                {
                    var key = GetRuleName(ctrl.Name);
                    DateTimeInput input = (ctrl as DateTimeInput);
                    input.Value = DateTime.Now;
                }
                else if (ctrl is CheckBoxX)//默认选中
                {
                    var key = GetRuleName(ctrl.Name);
                    (ctrl as CheckBoxX).Checked = true;

                }
                else if (ctrl is IntegerInput)
                {
                    (ctrl as IntegerInput).Value = 1;
                }
                else if (ctrl is DoubleInput)
                {
                    (ctrl as DoubleInput).Value = 1;
                }
            }
        }

        /// <summary>
        /// 保存时调用获取控制,
        /// </summary>
        /// <param name="control"></param>
        protected Dictionary<string, EditFormControlInfo> controls = new Dictionary<string, EditFormControlInfo>();

        /// <summary>
        /// 程序加载时获取控件
        /// </summary>
        /// <param name="control"></param>
        private void GetControls(Control control)
        {
            foreach (Control ctrl in control.Controls)
            {
                if (ctrl is Panel)
                {
                    if (ctrl.Controls.Count > 0)
                    {
                        GetControls(ctrl);
                    }
                }
                if (ctrl is LayoutControl)
                {
                    if (ctrl.Controls.Count > 0)
                    {
                        GetControls(ctrl);
                    }
                }
                else if (ctrl is TextBox)
                {

                    var key = GetRuleName(ctrl.Name);
                    var value = ctrl.Text;
                    if (!controls.ContainsKey(key))
                    {
                        controls.Add(key, new EditFormControlInfo(  ctrl.Name, ctrl,  value ));
                    }

                }
                else if (ctrl is IntegerInput)
                {
                    var key = GetRuleName(ctrl.Name);
                    int value = (ctrl as IntegerInput).Value;
                    if (!controls.ContainsKey(key))
                    {
                        controls.Add(key, new EditFormControlInfo(ctrl.Name, ctrl, value));
                    }
                }
                else if (ctrl is DateTimeInput)
                {
                    var key = GetRuleName(ctrl.Name);
                    DateTime value = (ctrl as DateTimeInput).Value;
                    if (!controls.ContainsKey(key))
                    {
                        controls.Add(key, new EditFormControlInfo(ctrl.Name, ctrl, value));
                    }
                }
                else if (ctrl is CheckBox)
                {
                    var key = GetRuleName(ctrl.Name);
                    bool value = (ctrl as CheckBox).Checked;
                    if (!controls.ContainsKey(key))
                    {
                        controls.Add(key, new EditFormControlInfo(ctrl.Name, ctrl, value));
                    }
                }
                else if (ctrl is DoubleInput)
                {
                    var key = GetRuleName(ctrl.Name);
                    var value = (ctrl as DoubleInput).Value;
                    if (!controls.ContainsKey(key))
                    {
                        controls.Add(key, new EditFormControlInfo(ctrl.Name, ctrl, value));
                    }
                }
                //类型未判断完
            }
        }

        #endregion
        protected virtual string GetRuleName(string name)
        {
            if (!name.Contains('_'))
            {

                throw new Exception("编辑页面命名规则请以控件宿写_加上属性名称,例如txt_Code!");
            }

            return name.Split('_')?.LastOrDefault();
        }
        #region 注册事件


        private void EditFormToolBar_CloseClick(object sender, EventArgs e)
        {

            this.Close();
        }


        private void EditFormToolBar_SaveClick(object sender, EventArgs e)
        {
            if (EntityType == null)
            {
                throw new Exception($"编辑窗休未重写{nameof(EntityType)}属性");
            }
            ButtonItem button = (ButtonItem)sender;
            button.Enabled = false;
            try
            {
                var flag = Save();
                if (flag)
                {
                    MessageBoxEx.Show("操作成功!");
                    Close();
                }
                else
                {
                    button.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                button.Enabled = true;
                throw ex;
            }
        }
        private void EditFormToolBar_SaveAndNewClick(object sender, EventArgs e)
        {
            ButtonItem button = (ButtonItem)sender;
            button.Enabled = false;
            var flag = Save();
            if (flag)
            {
                Id = 0;
                IsAdd = true;
                button.Enabled = true;
            }
            else
            {
                Id = 0;
                IsAdd = true;
                button.Enabled = true;
            }

        }
        private  bool Save()
        {

            var flag = false;
            try
            {
                flag = OnSaveBefor();
                if (flag)
                {
                    flag = OnSave();
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                if (flag)
                {
                    flag = OnSaveAfter();
                }
            }
            return flag;
        }
        #endregion

        #region 验证提示
        /// <summary>
        /// 验证提示
        /// </summary>
        /// <param name="control">控件</param>
        /// <param name="text">提示信息</param>
        /// <returns></returns>
        protected virtual bool ValidateTip(Control control, string text = "不能为空")
        {
            text = string.IsNullOrEmpty(text) ? control.Name : text;
            balloonTip.SetBalloonCaption(control, "提示");
            balloonTip.AutoCloseTimeOut = 2;
            balloonTip.SetBalloonText(control, text);
            balloonTip.CaptionIcon = SystemIcons.Error;
            balloonTip.ShowBalloon(control);
            control.Select();
            control.Focus();
            return false;
        }
        #endregion

        #region 保存
        protected virtual bool OnSaveBefor()
        {
            //操作数据库或者请求

            return true;
        }
        protected virtual bool OnSave()
        {
            return true;
        }
        protected virtual bool OnSaveAfter()
        {
            return true;
        }
        #endregion

    }

    public class EditFormControlInfo
    {

        public EditFormControlInfo() { }
        public EditFormControlInfo(string controlName, Control control, object value)
        {

            this.Control = control;
            this.ControlName = controlName;
            this.Value = value;
        }
        /// <summary>
        /// 控制名称
        /// </summary>
        public string ControlName { get; set; }

        /// <summary>
        /// 实体属性名称
        /// </summary>
        public string EntityPropertieName
        {
            get
            {
                return ControlName.Split('_').LastOrDefault();
            }
        }
        /// <summary>
        /// 控制的值
        /// </summary>
        public object Value { get; set; }
        /// <summary>
        /// 控件信息
        /// </summary>

        public Control Control { get; set; }


    }
}
