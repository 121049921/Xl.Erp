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

namespace Xl.Client.Bs
{
    public partial class RepairOrderEditFrom : BaseBusinessEditForm
    {
        public RepairOrderEditFrom()
        {

            InitializeComponent();
        }
        //重写方法1(要保存的实体对象)
        protected override Type EntityType
        {
            get { return typeof(RepairOrder); }
        }
        //重写方法2
        protected override void BindOtherData()
        {
            BindGender();
            BindProvince();
            BindCity();
            BindDistrict();
            BindBrand();
            BindHomeElectronicsType();
        }
        /// <summary>
        /// 重写方法3
        /// </summary>
        /// <returns></returns>
        protected override bool OnSave()
        {
            //写自己的业务操作
            return base.OnSave();
        }
        #region 绑定数据,这里只是演示数据,简单处理
        private void BindGender()
        {
            this.cmb_Gender.DisplayMember = "Name";
            this.cmb_Gender.ValueMember = "Id";
            DataTable dt = new DataTable();
            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("Name", typeof(string));

            dt.Rows.Add(new object[] { 1, "男" });
            dt.Rows.Add(new object[] { 2, "女" });
            this.cmb_Gender.DataSource = dt;
        }
        private void BindProvince()
        {
            this.cmb_Province.DisplayMember = "Name";
            this.cmb_Province.ValueMember = "Id";
            DataTable dt = new DataTable();
            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("Name", typeof(string));

            dt.Rows.Add(new object[] { 1, "湖北省" });
            dt.Rows.Add(new object[] { 2, "湖南省" });
            dt.Rows.Add(new object[] { 3, "河北省" });
            this.cmb_Province.DataSource = dt;
        }
        private void BindCity()
        {
            this.cmb_City.DisplayMember = "Name";
            this.cmb_City.ValueMember = "Id";
            DataTable dt = new DataTable();
            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("Name", typeof(string));

            dt.Rows.Add(new object[] { 1, "荆门市" });
            dt.Rows.Add(new object[] { 2, "荆州市" });
            dt.Rows.Add(new object[] { 3, "宜昌市" });
            this.cmb_City.DataSource = dt;
        }
        private void BindDistrict()
        {
            this.cmb_District.DisplayMember = "Name";
            this.cmb_District.ValueMember = "Id";
            DataTable dt = new DataTable();
            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("Name", typeof(string));

            dt.Rows.Add(new object[] { 1, "A1" });
            dt.Rows.Add(new object[] { 2, "A2" });
            dt.Rows.Add(new object[] { 3, "A3" });
            this.cmb_District.DataSource = dt;
        }
        private void BindBrand()
        {
            this.cmb_Brand.DisplayMember = "Name";
            this.cmb_Brand.ValueMember = "Id";
            DataTable dt = new DataTable();
            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("Name", typeof(string));

            dt.Rows.Add(new object[] { 1, "松下" });
            dt.Rows.Add(new object[] { 2, "美的" });
            dt.Rows.Add(new object[] { 3, "西门子" });
            this.cmb_Brand.DataSource = dt;
        }
        private void BindHomeElectronicsType()
        {

            var result = EnumHelper.GetDescriptionDictionary<HomeElectronicsType>();
            DataTable dt = new DataTable();
            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("Name", typeof(string));
            foreach (var item in result)
            {
                dt.Rows.Add(new object[] { item.Key, item.Value });
            }

            this.cmb_HomeElectronicsType.DisplayMember = "Name";
            this.cmb_HomeElectronicsType.ValueMember = "Id";
            this.cmb_HomeElectronicsType.DataSource = dt;
        }

        #endregion

    }
}
