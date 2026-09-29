using Common;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using static BCMS.CustomControls.TextInput;

namespace BCMS.CustomControls
{
    public partial class PhoneInput : Guna2TextBox
    {
        public PhoneInput()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        public Boolean IsInputValid()
        {
            return Validation.IsPhoneNumberValid(this.Text);
        }
    }
}
