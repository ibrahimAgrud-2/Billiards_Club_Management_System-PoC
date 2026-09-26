using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCMS_Business;
using BCMS_Business.Users;

namespace BCMS
{
    public partial class frmListUser : BaseForm
    {
        public frmListUser()
        {
            InitializeComponent();
        }

   

        private DataTable _DtUsers;


        private Dictionary<string, string> _ColumnNames = new Dictionary<string, string>
            {
              { "UserName", "User Name" },
              { "IsActive", "Is ActiveS" }
            };
        private void _SetColumnNames()
        {
            foreach (KeyValuePair<string, string> dict in _ColumnNames)
            {
                dgvUsers.Columns[dict.Key].HeaderText = dict.Value;
            }

        }

        private void _RefreshPeopleList()
        {
            _DtUsers = User.GetUserList();

            dgvUsers.DataSource = _DtUsers.DefaultView.ToTable("Users", false, "UserName", "IsActive");


        }
        private void ListUser_Load(object sender, EventArgs e)
        {
            _RefreshPeopleList();
        }

    }
}
