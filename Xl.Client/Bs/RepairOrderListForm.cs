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

namespace Xl.Client.Bs
{
    public partial class RepairOrderListForm : ListBaseForm
    {
        public RepairOrderListForm()
        {
            InitializeComponent();
        }


        protected override Type EditBaseForm
        {
            get
            {
                return typeof(RepairOrderEditFrom);
            }
        }
        protected override Type BindGridEntity
        {
            get
            {
                return typeof(RepairOrder);
            }
        }



        /// <summary>
        /// 假数据
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        private PageResult<List<RepairOrder>> GetUserList(PageabledEventArgs args)
        {
            PageResult<List<RepairOrder>> pageResult = new PageResult<List<RepairOrder>>();

            List<RepairOrder> result = new List<RepairOrder>();
            for (int i = 0; i < 2000; i++)
            {
                var model = new RepairOrder()
                {
                    Adress = "石岩",
                    AppointmentDateTime = DateTime.Now,
                    Brand = "电器",
                    City = "ab",
                    Code = "10001" + i,
                    CustomName = "夏磊" + i,
                    Description = "ab",
                    DoorToDoorAmount = 30,
                    Gender = Gender.Men,
                     VisitingDateTime=DateTime.Now.AddDays(0.5),
                      
                   
                    IsMaintenanceSuccessed = true,
                    IsEabled = true,
                    MaintenanceAmount = 600,
                    
                    MaintenanceMaster = "张师傅",
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
                    model.Gender = Gender.Men;
                }
                result.Add(model);
            }
            var count = result.Count();
            if (args != null)
            {
                if (!string.IsNullOrEmpty(args.Key))
                {
                    result = result.Where(exp => exp.Code.Contains(args.Key)).ToList();
                    count = result.Count();
                }
            }
            pageResult.Data = result.Skip((args.PageIndex - 1) * args.PageSize).Take(args.PageSize).ToList();
            pageResult.Total = count;
            return pageResult;
        }
        protected override void DeleteClick(object sender, PageabledEventArgs args)
        {
            List<int> ids = base.GetSelectRows();
            var result = GetUserList(args);
            List<RepairOrder> deleteUsers = new List<RepairOrder>();
            deleteUsers.AddRange(result.Data.Where(x => ids.Contains(x.Id)).ToList());
            foreach (var item in deleteUsers)
            {
                result.Data.Remove(item);
            }
            args.TotalCount = result.Total;
            base.BindGrid(result.Data, args);

        }
        protected override void BindGrid<T>(List<T> source, PageabledEventArgs args)
        {

            var result = GetUserList(args);
            args.TotalCount = result.Total;
            base.BindGrid(result.Data, args);
        }


    }
}
