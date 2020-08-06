using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Xl.UIComponent
{
    public partial class BaseForm : DevComponents.DotNetBar.Office2007Form
    {
        public BaseForm()
        {
            InitializeComponent();
            this.EnableGlass = false;
        }
    }
}
