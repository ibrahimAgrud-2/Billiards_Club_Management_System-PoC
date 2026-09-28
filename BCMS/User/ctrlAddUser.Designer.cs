namespace BCMS.User
{
    partial class ctrlAddUser
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrlAddUser));
            this.pbPersonImage = new System.Windows.Forms.PictureBox();
            this.lnkLblRemove = new System.Windows.Forms.LinkLabel();
            this.lnklblSetImage = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.mskPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.mskLastName = new System.Windows.Forms.MaskedTextBox();
            this.mskFirstName = new System.Windows.Forms.MaskedTextBox();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label15 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pbPersonImage
            // 
            this.pbPersonImage.Location = new System.Drawing.Point(453, 16);
            this.pbPersonImage.Name = "pbPersonImage";
            this.pbPersonImage.Size = new System.Drawing.Size(215, 248);
            this.pbPersonImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPersonImage.TabIndex = 176;
            this.pbPersonImage.TabStop = false;
            this.pbPersonImage.Tag = "0";
            // 
            // lnkLblRemove
            // 
            this.lnkLblRemove.AutoSize = true;
            this.lnkLblRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.89076F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkLblRemove.Location = new System.Drawing.Point(528, 326);
            this.lnkLblRemove.Name = "lnkLblRemove";
            this.lnkLblRemove.Size = new System.Drawing.Size(81, 24);
            this.lnkLblRemove.TabIndex = 175;
            this.lnkLblRemove.TabStop = true;
            this.lnkLblRemove.Text = "Remove";
            this.lnkLblRemove.Visible = false;
            // 
            // lnklblSetImage
            // 
            this.lnklblSetImage.AutoSize = true;
            this.lnklblSetImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.89076F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnklblSetImage.Location = new System.Drawing.Point(514, 296);
            this.lnklblSetImage.Name = "lnklblSetImage";
            this.lnklblSetImage.Size = new System.Drawing.Size(94, 24);
            this.lnklblSetImage.TabIndex = 174;
            this.lnklblSetImage.TabStop = true;
            this.lnklblSetImage.Text = "Set Image";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.89076F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(16, 104);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 32);
            this.label1.TabIndex = 173;
            this.label1.Text = "Last Name";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.89076F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(174, 335);
            this.txtAddress.MaxLength = 2000;
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(242, 95);
            this.txtAddress.TabIndex = 172;
            // 
            // mskPhoneNumber
            // 
            this.mskPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.89076F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskPhoneNumber.HidePromptOnLeave = true;
            this.mskPhoneNumber.Location = new System.Drawing.Point(175, 216);
            this.mskPhoneNumber.Mask = "(999) 000-0000";
            this.mskPhoneNumber.Name = "mskPhoneNumber";
            this.mskPhoneNumber.PromptChar = ' ';
            this.mskPhoneNumber.Size = new System.Drawing.Size(236, 28);
            this.mskPhoneNumber.TabIndex = 171;
            // 
            // mskLastName
            // 
            this.mskLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.89076F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskLastName.HidePromptOnLeave = true;
            this.mskLastName.Location = new System.Drawing.Point(175, 110);
            this.mskLastName.Mask = "LL???????????????????????????????????????????";
            this.mskLastName.Name = "mskLastName";
            this.mskLastName.PromptChar = ' ';
            this.mskLastName.Size = new System.Drawing.Size(236, 28);
            this.mskLastName.TabIndex = 170;
            // 
            // mskFirstName
            // 
            this.mskFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.89076F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskFirstName.HidePromptOnLeave = true;
            this.mskFirstName.Location = new System.Drawing.Point(174, 57);
            this.mskFirstName.Mask = "LL???????????????????????????????????????????";
            this.mskFirstName.Name = "mskFirstName";
            this.mskFirstName.PromptChar = ' ';
            this.mskFirstName.Size = new System.Drawing.Size(237, 28);
            this.mskFirstName.TabIndex = 169;
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.89076F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBirthDate.Location = new System.Drawing.Point(175, 169);
            this.dtpBirthDate.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(236, 28);
            this.dtpBirthDate.TabIndex = 168;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.89076F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label5.Location = new System.Drawing.Point(16, 51);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 32);
            this.label5.TabIndex = 167;
            this.label5.Text = "Name";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.89076F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label6.Location = new System.Drawing.Point(16, 355);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 32);
            this.label6.TabIndex = 166;
            this.label6.Text = "Address";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.89076F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Image = ((System.Drawing.Image)(resources.GetObject("label7.Image")));
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label7.Location = new System.Drawing.Point(16, 279);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 32);
            this.label7.TabIndex = 165;
            this.label7.Text = "Email";
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.89076F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Image = ((System.Drawing.Image)(resources.GetObject("label13.Image")));
            this.label13.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label13.Location = new System.Drawing.Point(16, 162);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(150, 33);
            this.label13.TabIndex = 164;
            this.label13.Text = "Birth Date";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.89076F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Image = ((System.Drawing.Image)(resources.GetObject("label11.Image")));
            this.label11.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label11.Location = new System.Drawing.Point(16, 219);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(129, 33);
            this.label11.TabIndex = 163;
            this.label11.Text = "Phone: ";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.89076F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(175, 276);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(236, 28);
            this.txtEmail.TabIndex = 162;
            // 
            // btnGoBack
            // 
            this.btnGoBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnGoBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGoBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.89076F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGoBack.Location = new System.Drawing.Point(453, 394);
            this.btnGoBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(98, 36);
            this.btnGoBack.TabIndex = 160;
            this.btnGoBack.Text = "Go Back";
            this.btnGoBack.UseVisualStyleBackColor = true;
            this.btnGoBack.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.89076F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(199, 10);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(45, 24);
            this.label15.TabIndex = 161;
            this.label15.Text = "First";
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.89076F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(570, 394);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 36);
            this.button1.TabIndex = 159;
            this.button1.Text = "Save";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ctrlAddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pbPersonImage);
            this.Controls.Add(this.lnkLblRemove);
            this.Controls.Add(this.lnklblSetImage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.mskPhoneNumber);
            this.Controls.Add(this.mskLastName);
            this.Controls.Add(this.mskFirstName);
            this.Controls.Add(this.dtpBirthDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.btnGoBack);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.button1);
            this.Name = "ctrlAddUser";
            this.Size = new System.Drawing.Size(683, 451);
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPersonImage;
        private System.Windows.Forms.LinkLabel lnkLblRemove;
        private System.Windows.Forms.LinkLabel lnklblSetImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.MaskedTextBox mskPhoneNumber;
        private System.Windows.Forms.MaskedTextBox mskLastName;
        private System.Windows.Forms.MaskedTextBox mskFirstName;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnGoBack;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button button1;
    }
}
