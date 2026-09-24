using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BCMS
{
    public partial class TextBoxt : TextBox
    {
        public TextBoxt()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        public bool IsRequired { get; set; }


        public enum enInputType { TextInput, NumberIntput };

        public enInputType InputType { get; set; }

        private bool IsNumeric()
        {
            string s = this.Text.Trim();
            foreach (char c in s)
            {
                if(!char.IsDigit(c)&&c!='.')
                {
                    return false;
                }

            }
            return true;
        }
        public bool IsValid()
        {
            if(IsRequired)
            {
                if (this.Text.Trim().Length==0)
                {
                    return false;
                }
                if(this.InputType==enInputType.NumberIntput)
                {
                    return IsNumeric();
                }

            }
            return true;
        }
    }
}
