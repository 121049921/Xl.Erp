using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace Xl.UIComponent
{
    public partial class EditFormToolBar : UserControl
    {
        public EditFormToolBar()
        {
            InitializeComponent();
            DisplayEditFormToolButton = EditFormToolButton.btnSave | EditFormToolButton.btnSaveAndNew | EditFormToolButton.btnClose;
        }
        public event EventHandler CloseClick;
        public event EventHandler SaveClick;
        public event EventHandler SaveAndNewClick;
        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveClick?.Invoke(sender, e);
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            CloseClick?.Invoke(sender, e);
        }
        private void btnSaveAndNew_Click(object sender, EventArgs e)
        {
            SaveAndNewClick?.Invoke(sender, e);
        }
        private EditFormToolButton displayEditFormToolButton;
        public EditFormToolButton DisplayEditFormToolButton
        {
            get { return displayEditFormToolButton; }
            set
            {
                OnDisplayEditFormToolButtonChange(value);
                displayEditFormToolButton = value;
            }
        }

        private void OnDisplayEditFormToolButtonChange(object value)
        {
            if (value != null)
            {
                EditFormToolButton button = (EditFormToolButton)value;
                switch (button)
                {
                    case EditFormToolButton.btnSave:
                        btnSave.Visible = (button & EditFormToolButton.btnSave)== EditFormToolButton.btnSave;
                        break;
                    case EditFormToolButton.btnSaveAndNew:
                        btnSaveAndNew.Visible = (button & EditFormToolButton.btnSaveAndNew) == EditFormToolButton.btnSaveAndNew;
                        break;
                    case EditFormToolButton.btnClose:
                        btnClose.Visible = (button & EditFormToolButton.btnClose) == EditFormToolButton.btnClose;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
