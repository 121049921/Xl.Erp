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
    public partial class ListFormToolBar : UserControl
    {
        public event EventHandler AddClick;
        public event EventHandler EditClick;
        public event Action<object, PageabledEventArgs> DeleteClick;
        public event EventHandler CloseClick;
        public event Action<object, PageabledEventArgs> SearchClick;
        public event Action<object, PageabledEventArgs> AdvSearchClick;
        public ListFormToolBar()
        {
            InitializeComponent();
            //this.galleryContainer.add
        }

        protected virtual void btnAdd_Click(object sender, EventArgs e)
        {
            AddClick?.Invoke(sender, e);
        }

        protected virtual void btnEdit_Click(object sender, EventArgs e)
        {
            EditClick?.Invoke(sender, e);
        }

        protected virtual void btnSearch_Click(object sender, EventArgs e)
        {
           
            SearchClick?.Invoke(sender, InitPageabledEventArgs());
        }

        protected virtual void btnDelete_Click(object sender, EventArgs e)
        {
            
            DeleteClick?.Invoke(sender, InitPageabledEventArgs());

        }

        protected virtual void btnClose_Click(object sender, EventArgs e)
        {
            CloseClick?.Invoke(sender, e);

        }

        private void btnAdvSearch_Click(object sender, EventArgs e)
        {

            AdvSearchClick?.Invoke(sender, InitPageabledEventArgs());
        }
        private PageabledEventArgs InitPageabledEventArgs()
        {
            return new PageabledEventArgs()
            {
                StartTime = DateTime.Now,
                EndTime = DateTime.Now,
                Key = this.txtSearchKey.Text,
                Name = this.txtSearchKey.Text,
                Status = -1,
                PageIndex = 1

            };
        }
    }


}
