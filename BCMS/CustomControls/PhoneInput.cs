using Common;
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
    public partial class PhoneInput : TextBox
    {
        public PhoneInput()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        public Boolean IsInputValid(string phoneNumber)
        {
            return Validation.IsPhoneNumberValid(phoneNumber);
        }
    }
}
