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
    public partial class SelectDowpDownList : UserControl
    {

        public event Action<object, EventArgs> OpenDialog;
        public SelectDowpDownList()
        {
            InitializeComponent();
        }

        private void btnDialog_Click(object sender, EventArgs e)
        {
            OpenDialog?.Invoke(sender, e);
        }
    }
}
