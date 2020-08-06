using DevComponents.DotNetBar.SuperGrid;
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
    public partial class SysUserListForm : ListBaseForm
    {
        public SysUserListForm()
        {
            InitializeComponent();
        }


        protected override Type EditBaseForm
        {
            get
            {
                return typeof(SysUserEditForm);
            }
        }
        protected override Type BindGridEntity
        {
            get
            {
                return typeof(SysUser);
            }
        }

       

        /// <summary>
        /// 假数据
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        private PageResult<List<SysUser>> GetUserList(PageabledEventArgs args)
        {
            PageResult<List<SysUser>> pageResult = new PageResult<List<SysUser>>();

            List<SysUser> result = new List<SysUser>();
            for (int i = 0; i < 2000; i++)
            {
                var user = new SysUser()
                {
                    Id = i + 1,
                    BrithDay = DateTime.Now,
                    IsAdmin = true,
                    Name = "刘德华" + (i + 1),
                    LoginName = "ldh" + "100000" + (i + 1),
                    Sex = Sex.Men,
                    CreateUserId = 1,
                    CreateUserName = "张学友",
                    CreateTime = DateTime.Now,
                    Remark = "此人是歌神",
                    Sort = i + 1,
                    UpdateUserId = 1,
                    UpdateUserName = "张学友",
                    UpdateTime = DateTime.Now
                };
                if (i % 2 == 0)
                {
                    user.Sex = Sex.Men;
                }
                result.Add(user);
            }
            var count = result.Count();
            if (args != null)
            {
                if (!string.IsNullOrEmpty(args.Name))
                {
                    result = result.Where(exp => exp.Name.Contains(args.Key)).ToList();
                    count = result.Count();
                }
            }
            pageResult.Data  = result.Skip((args.PageIndex - 1) * args.PageSize).Take(args.PageSize).ToList();
            pageResult.Total = count;
            return pageResult;
        }
        protected override void DeleteClick(object sender, PageabledEventArgs args)
        {
            List<int> ids = base.GetSelectRows();
            var result = GetUserList(args);
            List<SysUser> deleteUsers = new List<SysUser>();
            deleteUsers.AddRange(result.Data.Where(x => ids.Contains(x.Id)).ToList());
            foreach (var item in deleteUsers)
            {
                result.Data.Remove(item);
            }
            args.TotalCount = result.Total;
            base.BindGrid(result.Data, args);
            base.DeleteClick(sender, args);

        }
        protected override void BindGrid<T>(List<T> source, PageabledEventArgs args)
        {

            var result = GetUserList(args);
            args.TotalCount = result.Total;
            base.BindGrid(result.Data, args);
        }

      
    }
}
