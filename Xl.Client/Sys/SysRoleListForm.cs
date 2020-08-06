using LiteDB;
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

    public partial class SysRoleListForm : ListBaseForm
    {
        public SysRoleListForm()
        {
            InitializeComponent();
        }

        protected override Type EditBaseForm
        {
            get
            {
                return typeof(SysRoleEditForm);
            }
        }
        protected override Type BindGridEntity
        {
            get
            {
                return typeof(SysRole);
            }
        }
        protected override void BindGrid<T>(List<T> source, PageabledEventArgs args)
        {
            Query query = null;
            if (!string.IsNullOrEmpty(args.Key))
            {
                var query1 = Query.Contains(nameof(SysRole.Name), args.Key);
                var query2 = Query.Contains(nameof(SysRole.Code), args.Key);
                query = Query.Or(query1, query2);
            }
            int count = 0;
            var xx = LiteDbHelper.Instanc.FindAll<SysRole>();
            var result = LiteDbHelper.Instanc.Find<SysRole>(out count, query, (args.PageIndex - 1) * args.PageSize, args.PageSize);
            args.TotalCount = count;
            base.BindGrid(result, args);
          

        }
    }
}
