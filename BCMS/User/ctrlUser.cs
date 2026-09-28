using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BCMS_Business.Users;

namespace BCMS.User
{
    public partial class ctrlUser : UserControl
    {
        public ctrlUser()
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
                dgvUser.Columns[dict.Key].HeaderText = dict.Value;
            }

        }

        private void _RefreshPeopleList()
        {
            _DtUsers = BCMS_Business.Users.User.GetUserList();
            dgvUser.DataSource = _DtUsers.DefaultView.ToTable("Users", false, "UserName", "IsActive");
        }

        public void LoadUserData()
        {
            _RefreshPeopleList();
        }

  


    }
}
