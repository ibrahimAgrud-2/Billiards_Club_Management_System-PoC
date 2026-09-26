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
    public partial class frmMain : BaseForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void baseButton2_Click(object sender, EventArgs e)
        {

        }

  

        private void guna2TabControl1_Click(object sender, EventArgs e)
        {
            frmListUser listUser = new frmListUser();
            listUser.ShowDialog();
        }
    }
}
