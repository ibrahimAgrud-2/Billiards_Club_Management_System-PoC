using BCMS.Properties;
using BCMS_Business.People;
using BCMS_Business.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheArtOfDevHtmlRenderer.Adapters;

namespace BCMS.User
{
    public partial class ctrlAddUpdateUser : UserControl
    {
        public ctrlAddUpdateUser()
        {
            InitializeComponent();
            this._Mode = enMode.enAddNew;
            dtpBirthDate.MaxDate = DateTime.Now.Date.AddYears(-18);
            temp();
            _User = new BCMS_Business.Users.User();
        }

        private void temp()
        {


            txtFirstName.Text = "anil";
            txtLastName.Text = "Yilmaz";
            emailInput1.Text = "ibra@gmail.com";
            txtAddress.Text = "Ankara";
            phoneInput1.Text = "05431345447";
            txtUserName.Text = "YilmazAdmin";
            mskPassword.Text = "1234";
            cbIsActive.Checked = true;

        }


        public delegate void AddCanceledEventHandler();

        public event AddCanceledEventHandler AddCanceled;


        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
            AddCanceled?.Invoke();
        }

        enum enMode { enAddNew = 1, enUpdate = 2 };
        private enMode _Mode;
        BCMS_Business.Users.User _User;
        private bool _FillDataToObject()
        {

            if (this.ValidateChildren())
            {
                _User.ImagePath = "C";
                _User.BirthDate = dtpBirthDate.Value;
                _User.FirstName = txtFirstName.Text.Trim();
                _User.LastName = txtLastName.Text.Trim();
                _User.Email = emailInput1.Text.Trim();
                _User.Address = txtAddress.Text.Trim();
                _User.Phone = phoneInput1.Text.Trim();
                _User.UserName = txtUserName.Text.Trim();
                _User.Password = mskPassword.Text.Trim();
                _User.IsActive = cbIsActive.Checked;
                return true;
            }
            else
            {
                return false;
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
           if(_FillDataToObject())
            {
                if (_User.Save())
                {
                    MessageBox.Show(
                        "Operation completed successfully.",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(
                        "User Could Not Saved. Please try again.",
                        "Failure",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            else
                {
                        MessageBox.Show(
                  "Field values are not appropriate for object variables.",
                  "Failure",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
                }
            
        }

        private void txtFirstName_Validating(object sender, CancelEventArgs e)
        {

            if (!txtFirstName.IsInputValid())
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFirstName, "This field is required!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtFirstName, "");
            }
        }

        private void txtLastName_Validating(object sender, CancelEventArgs e)
        {
            if (!txtLastName.IsInputValid())
            {
                e.Cancel = true;
                errorProvider1.SetError(txtLastName, "This field is required!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtLastName, "");
            }
        }


        private void emailInput1_Validating(object sender, CancelEventArgs e)
        {
            if (!emailInput1.IsInputValid())
            {
                e.Cancel = true;
                errorProvider1.SetError(emailInput1, "This field is required!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(emailInput1, "");
            }
        
        }

        private void txtAddress_Validating(object sender, CancelEventArgs e)
        {
            if (!txtAddress.IsInputValid())
            {
                e.Cancel = true;
                errorProvider1.SetError(txtAddress, "This field is required!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtAddress, "");
            }
        }

        private void phoneInput1_Validating_1(object sender, CancelEventArgs e)
        {            
            
            if (!phoneInput1.IsInputValid())
            {
                e.Cancel = true;
                errorProvider1.SetError(phoneInput1, "This field is required!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(phoneInput1, "");
            }

        }
    }
}
