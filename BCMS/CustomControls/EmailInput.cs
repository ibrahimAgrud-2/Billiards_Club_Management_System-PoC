using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BCMS.CustomControls
{
    public partial class EmailInput : TextBox
    {
        public EmailInput()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        public Boolean IsInputValid()
        {
            if (this.Text.Trim().Length!=0)
            {
                return Common.Validation.IsEmailValid(this.Text);
                     
            }
            
            return true;
        }
    }
}
