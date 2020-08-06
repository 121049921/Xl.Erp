using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Xl.UIComponent
{
    public partial class PageToolBar : UserControl
    {
        public PageToolBar()
        {
            InitializeComponent();
            InitCmbPageSize();

        }

        private string lbPageText = "第{0}页,  共{1}页,  数据{2}条";
        private void InitCmbPageSize()
        {
            this.cmbPageSize.Items.Add(25);
            this.cmbPageSize.Items.Add(50);
            this.cmbPageSize.Items.Add(100);
            this.cmbPageSize.Items.Add(500);
            this.cmbPageSize.Items.Add(1000);
            this.cmbPageSize.Items.Add(10000);
            this.cmbPageSize.SelectedIndex = 0;
        }
        public PageabledEventArgs PageabledEventArgs = new PageabledEventArgs();
        public virtual event Action<object, PageabledEventArgs> PrevClick;
        public virtual event Action<object, PageabledEventArgs> NextClick;
        public virtual event Action<object, PageabledEventArgs> CmbPageSizeSelectedIndexChangedEvnet;

        private void btnPrev_Click(object sender, EventArgs e)
        {
            // 防止卡死UI
            this.btnPrex.Invoke(new Action(() =>
            {
                this.lbTip.Text = string.Empty;
                if (PageabledEventArgs.PageIndex <= 1)
                {
                    PageabledEventArgs.PageIndex = 1;

                    this.lbTip.Text = "第1页";
                }
                else
                {
                    this.lbTip.Text = string.Empty;
                    PageabledEventArgs.PageIndex--;
                    PrevClick?.Invoke(sender, PageabledEventArgs);
                }
            }));

        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            this.btnNext.Invoke(new Action(() =>
            {
                this.lbTip.Text = string.Empty;
                if (PageabledEventArgs.PageIndex >= PageabledEventArgs.PageCount)
                {
                    PageabledEventArgs.PageIndex = PageabledEventArgs.PageCount;
                    this.lbTip.Text = "最后1页";
                }
                else
                {
                    this.lbTip.Text = string.Empty;
                    PageabledEventArgs.PageIndex++;
                    NextClick?.Invoke(sender, PageabledEventArgs);
                }

            }));
        }
        public virtual void ChangePageCount(int totalCount)
        {

            lbPage.Text = lbPageText;
            var pageIndex = PageabledEventArgs.PageIndex.ToString();
            PageabledEventArgs.TotalCount = totalCount;
            var pageCount = (PageabledEventArgs.PageCount == 0 ? 1 : PageabledEventArgs.PageCount).ToString();
            lbPage.Text = string.Format(lbPage.Text, pageIndex, pageCount.ToString(), totalCount.ToString());
        }

        private void cmbPageSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.lbTip.Text = string.Empty;
            this.cmbPageSize.Invoke(new Action(() =>
            {
                PageabledEventArgs.PageIndex = 1;//重置到第一页
                PageabledEventArgs.PageSize = Convert.ToInt32(this.cmbPageSize.SelectedItem);
                CmbPageSizeSelectedIndexChangedEvnet?.Invoke(sender, PageabledEventArgs);

            }));
        }
    }


}
