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
    public partial class TextInput : TextBox
    {
        public TextInput()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        public bool IsRequired { set; get; }

        public enum enInputType { Text = 1, Number = 2 }

        private enInputType _InputType;

        public enInputType InputType { set { _InputType = value; } get { return _InputType; } }


        public enum InputTypeEnum { TextInput, NumberInput }




        public Boolean IsInputValid()
        {
            if (IsRequired)
            {
                if (this.Text.Trim().Length == 0)
                    return false;
            }

            if (InputType == enInputType.Number)
            {

                return Common.Validation.IsNumeric(this.Text);
            }

            return true;
        }

    }
}
