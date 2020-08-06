using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xl.Common;
using Xl.Model;
using Xl.UIComponent;

namespace Xl.Client
{
    public partial class SysRoleEditForm : BaseBusinessEditForm
    {
        public SysRoleEditForm()
        {

            InitializeComponent();

        }
        protected override Type EntityType
        {
            get { return typeof(SysRole); }
        }
        //绑定数据源
        protected override void OnFormLoading()
        {
            base.OnFormLoading();
        }
        protected override bool OnSaveBefor()
        {
            //也可以遍历控件找到属性
            if (string.IsNullOrEmpty(txt_Code.Text.Trim()))
            {
                return ValidateTip(txt_Code);
            }
            if (string.IsNullOrEmpty(txt_Name.Text.Trim()))
            {
                return ValidateTip(txt_Name);
            }
            return false;
        }
        protected override bool OnSave()
        {
            ////这里要移动基类中,先放这里
            //SysRole entity = base.GetControlsValue<SysRole>();
            //if (entity.Id <= 0)
            //{
            // LiteDbHelper.Instanc.Insert(entity);
            //}
            //else
            //{
            //    LiteDbHelper.Instanc.Update(entity);
            //}
            #region 单表
            BaUint sysRole = new BaUint();
            sysRole.Sort = 1;
            QueryExpression<BaUint> query1 = QueryExpression<BaUint>.Instanc.True();
            query1 = query1.Add(exp => exp.Id == 1 && exp.Id == sysRole.Sort || exp.CreateUserName == "456");
            if (1 == 1)
            {
                query1 = query1.Add(exp => exp.IsEabled == true);
            }
            if (2 == 2)
            {
                DateTime d = new DateTime(2019, 2, 4);
                query1 = query1.Or(exp => exp.UpdateTime == d);
                query1 = query1.Or(exp => exp.UpdateTime == DateTime.Now);
            }
            //单表
            List<BaUint> baUints = OmHelper.GetList<BaUint>(query1);

            #endregion
            #region 二表联查

            //var sql = SqlBuilder.Query<SysPosition, SysRole>((a, b) => new object[] { JoinType.InnerJoin, a.Code == b.Code && a.Id == b.Id }, null);
            #endregion

            #region 三表联查
            QueryExpression<SysPosition> query = QueryExpression<SysPosition>.Instanc.True();
            query = query.Add(exp => exp.Id == 1 && exp.Id == sysRole.Sort || exp.CreateUserName == "456");
            if (1 == 1)
            {
                query = query.Add(exp => exp.IsEabled == true);
            }
            if (2 == 2)
            {
                DateTime d = new DateTime(2019, 2, 4);
                query = query.Or(exp => exp.UpdateTime == d);
                query = query.Or(exp => exp.UpdateTime == DateTime.Now);
            }


            QueryExpression<SysRole> query2 = QueryExpression<SysRole>.Instanc.True();
            query2 = query2.Add(exp => exp.Id == 1 && exp.Id == sysRole.Sort || exp.CreateUserName == "456");
            if (1 == 1)
            {
                query2 = query2.Add(exp => exp.IsEabled == true);
            }



            
           // OmHelper.GetList<SysPosition, SysRole, SysUser, object>((a, b, c) =>
            //    new object[] { JoinType.InnerJoin,
            //                  a.Code == b.Code && a.Id == b.Id,
            //                  JoinType.InnerJoin,
            //                  a.Code == c.Code
            //                 }).Where(query);
            #endregion

            return base.OnSave();
        }


    }
}
