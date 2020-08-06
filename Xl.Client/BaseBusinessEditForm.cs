using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xl.UIComponent;
using System.Linq.Expressions;
using Xl.Model;
using DevComponents.Editors;
using DevComponents.Editors.DateTimeAdv;
using DevComponents.DotNetBar.Layout;
using DevComponents.DotNetBar.Controls;
using Xl.Client.Properties;
using Xl.Common;
using ServiceStack;

namespace Xl.Client
{
    /// <summary>
    /// 为了Xl.UIComponent组件完全脱离项目,可让任何项目用Xl.UIComponent组件
    /// </summary>
    public partial class BaseBusinessEditForm : EditBaseForm
    {

        public BaseBusinessEditForm()
        {
            InitializeComponent();
        }
        #region 加载窗体
        private void BaseBusinessEditForm_Load(object sender, EventArgs e)
        {
           
        }
        protected override void OnFormLoading()
        {
            base.OnFormLoading();
        }

        protected override void OnFormLoadAfter()
        {
            //GetCode();
            base.OnFormLoadAfter();
        }
        protected override void OnBindDataToControls()
        {
            if (Id <= 0)
            {
                base.SetDefaultValueToControls();
                BindOtherData();
            }
            else
            {
                BindOtherData();
                SetValueToControls();
            }
            base.OnBindDataToControls();

        }
        #endregion

        /// <summary>
        /// 绑定下拉框,checkBox,等其它数据
        /// </summary>
        protected virtual void BindOtherData()
        {



        }


        private void GetCode()
        {

            var code = LiteDbHelper.Instanc.Max(EntityType, "Code");
            if (code == GlobleParamters.DefaultCode || string.IsNullOrWhiteSpace(code))
            {
                code = GlobleParamters.DefaultCode;
                base.SetDefaulCodeToControls("Code", code);
            }
            else
            {
                if (code.Equals("+oo", StringComparison.OrdinalIgnoreCase))
                {
                    code = "10001";
                }
                else
                {
                    code = (Convert.ToInt32(code) + 1).ToString();
                }
                base.SetDefaulCodeToControls("Code", code);
            }
        }
        protected override bool OnSaveAfter()
        {
            return AutoValidateTip();
        }



        /// <summary>
        /// 自动验证属性加了Required,MaxLength等特性
        /// </summary>
        /// <returns></returns>
        private bool AutoValidateTip()
        {
            foreach (var item in controls)
            {
                EditFormControlInfo editFormControlInfo = item.Value;
                if (editFormControlInfo != null)
                {
                    var ctrl = editFormControlInfo.Control;
                    if (ctrl is TextBox)
                    {
                        var key = GetRuleName(ctrl.Name);
                        if (ctrl is TextBoxX)
                        {
                            TextBoxX textBox = ctrl as TextBoxX;
                            editFormControlInfo.Value = textBox.Text;
                        }
                    }
                    else if (ctrl is DateTimeInput)//默认时间
                    {
                     
                        DateTimeInput input = ctrl as DateTimeInput;
                        editFormControlInfo.Value = input.Value;
                    }
                    else if (ctrl is CheckBoxX)//默认选中
                    {
                        var key = GetRuleName(ctrl.Name);
                        CheckBoxX checkBoxX = ctrl as CheckBoxX;
                        editFormControlInfo.Value = checkBoxX.Checked;

                    }
                    else if (ctrl is IntegerInput)
                    {
                      
                        editFormControlInfo.Value = (ctrl as IntegerInput).Value;
                    }
                    else if (ctrl is DoubleInput)
                    {
                        editFormControlInfo.Value = (ctrl as DoubleInput).Value;
                    }

                    string mappingPropertieName = editFormControlInfo.EntityPropertieName;
                    if (!string.IsNullOrEmpty(mappingPropertieName))
                    {
                        if ( string.IsNullOrWhiteSpace(item.Value.Value?.ToString()))
                        {
                            var attrs = EntityType.GetProperty(mappingPropertieName)?.GetCustomAttributes(typeof(RequiredAttribute), true);
                            if (attrs != null)
                            {
                                RequiredAttribute requiredAttribute = attrs.FirstOrDefault() as RequiredAttribute;
                                if (requiredAttribute != null)
                                {

                                    return base.ValidateTip(item.Value.Control, requiredAttribute.ErrorMessage);
                                }
                            }
                            attrs = EntityType.GetProperty(mappingPropertieName)?.GetCustomAttributes(typeof(MaxLengthAttribute), true);
                            if (attrs != null)
                            {
                                MaxLengthAttribute maxLengthAttribute = attrs.FirstOrDefault() as MaxLengthAttribute;
                                if (maxLengthAttribute != null)
                                {
                                    return base.ValidateTip(item.Value.Control, maxLengthAttribute.ErrorMessage);
                                }
                            }
                        }
                    }
                    
                }
            }
            return true;
        }


    }
}
