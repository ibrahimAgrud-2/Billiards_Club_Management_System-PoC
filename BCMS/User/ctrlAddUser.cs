using BCMS_Business.People;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BCMS.User
{
    public partial class ctrlAddUser : UserControl
    {
        public ctrlAddUser()
        {
            InitializeComponent();
        }


        public delegate void AddCanceledEventHandler();

        public event AddCanceledEventHandler AddCanceled;


        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
            AddCanceled?.Invoke();

        }
    }
}
