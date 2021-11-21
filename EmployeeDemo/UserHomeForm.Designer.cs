namespace EmployeeDemo
{
    partial class UserHomeForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.salaryTxt = new System.Windows.Forms.TextBox();
            this.emailTxt = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.femaleRadioBtn = new System.Windows.Forms.RadioButton();
            this.maleRadioBtn = new System.Windows.Forms.RadioButton();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.employeeUpdateBtn = new System.Windows.Forms.Button();
            this.deleteEmployeeBtn = new System.Windows.Forms.Button();
            this.editEmployeeBtn = new System.Windows.Forms.Button();
            this.browseBtn = new System.Windows.Forms.Button();
            this.createEmpBtn = new System.Windows.Forms.Button();
            this.EmployeeDataTable = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchEmployeeTxt = new System.Windows.Forms.TextBox();
            this.goToChangePasswordForm = new System.Windows.Forms.Button();
            this.logOutBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NoticeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Details = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sendNoticeBtn = new System.Windows.Forms.Button();
            this.noticeTxt = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeDataTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 343);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 461);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Salary";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 407);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email";
            // 
            // nameTxt
            // 
            this.nameTxt.Enabled = false;
            this.nameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTxt.Location = new System.Drawing.Point(125, 320);
            this.nameTxt.Multiline = true;
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(251, 40);
            this.nameTxt.TabIndex = 4;
            // 
            // salaryTxt
            // 
            this.salaryTxt.Enabled = false;
            this.salaryTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salaryTxt.Location = new System.Drawing.Point(125, 438);
            this.salaryTxt.Multiline = true;
            this.salaryTxt.Name = "salaryTxt";
            this.salaryTxt.Size = new System.Drawing.Size(251, 40);
            this.salaryTxt.TabIndex = 5;
            // 
            // emailTxt
            // 
            this.emailTxt.Enabled = false;
            this.emailTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTxt.Location = new System.Drawing.Point(125, 384);
            this.emailTxt.Multiline = true;
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(251, 40);
            this.emailTxt.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.femaleRadioBtn);
            this.groupBox1.Controls.Add(this.maleRadioBtn);
            this.groupBox1.Location = new System.Drawing.Point(450, 515);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(191, 92);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gender";
            // 
            // femaleRadioBtn
            // 
            this.femaleRadioBtn.AutoSize = true;
            this.femaleRadioBtn.Enabled = false;
            this.femaleRadioBtn.Location = new System.Drawing.Point(25, 62);
            this.femaleRadioBtn.Name = "femaleRadioBtn";
            this.femaleRadioBtn.Size = new System.Drawing.Size(75, 21);
            this.femaleRadioBtn.TabIndex = 1;
            this.femaleRadioBtn.TabStop = true;
            this.femaleRadioBtn.Text = "Female";
            this.femaleRadioBtn.UseVisualStyleBackColor = true;
            // 
            // maleRadioBtn
            // 
            this.maleRadioBtn.AutoSize = true;
            this.maleRadioBtn.Enabled = false;
            this.maleRadioBtn.Location = new System.Drawing.Point(25, 23);
            this.maleRadioBtn.Name = "maleRadioBtn";
            this.maleRadioBtn.Size = new System.Drawing.Size(59, 21);
            this.maleRadioBtn.TabIndex = 0;
            this.maleRadioBtn.TabStop = true;
            this.maleRadioBtn.Text = "Male";
            this.maleRadioBtn.UseVisualStyleBackColor = true;
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox.Location = new System.Drawing.Point(450, 320);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(149, 150);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 9;
            this.pictureBox.TabStop = false;
            // 
            // employeeUpdateBtn
            // 
            this.employeeUpdateBtn.Enabled = false;
            this.employeeUpdateBtn.Location = new System.Drawing.Point(211, 561);
            this.employeeUpdateBtn.Name = "employeeUpdateBtn";
            this.employeeUpdateBtn.Size = new System.Drawing.Size(79, 37);
            this.employeeUpdateBtn.TabIndex = 10;
            this.employeeUpdateBtn.Text = "Update";
            this.employeeUpdateBtn.UseVisualStyleBackColor = true;
            this.employeeUpdateBtn.Click += new System.EventHandler(this.employeeUpdateBtn_Click);
            // 
            // deleteEmployeeBtn
            // 
            this.deleteEmployeeBtn.Enabled = false;
            this.deleteEmployeeBtn.Location = new System.Drawing.Point(297, 561);
            this.deleteEmployeeBtn.Name = "deleteEmployeeBtn";
            this.deleteEmployeeBtn.Size = new System.Drawing.Size(79, 37);
            this.deleteEmployeeBtn.TabIndex = 11;
            this.deleteEmployeeBtn.Text = "Delete";
            this.deleteEmployeeBtn.UseVisualStyleBackColor = true;
            this.deleteEmployeeBtn.Click += new System.EventHandler(this.deleteEmployeeBtn_Click);
            // 
            // editEmployeeBtn
            // 
            this.editEmployeeBtn.Enabled = false;
            this.editEmployeeBtn.Location = new System.Drawing.Point(125, 561);
            this.editEmployeeBtn.Name = "editEmployeeBtn";
            this.editEmployeeBtn.Size = new System.Drawing.Size(79, 37);
            this.editEmployeeBtn.TabIndex = 12;
            this.editEmployeeBtn.Text = "Edit Form";
            this.editEmployeeBtn.UseVisualStyleBackColor = true;
            this.editEmployeeBtn.Click += new System.EventHandler(this.editEmployeeBtn_Click);
            // 
            // browseBtn
            // 
            this.browseBtn.Enabled = false;
            this.browseBtn.Location = new System.Drawing.Point(524, 476);
            this.browseBtn.Name = "browseBtn";
            this.browseBtn.Size = new System.Drawing.Size(75, 33);
            this.browseBtn.TabIndex = 13;
            this.browseBtn.Text = "Browse";
            this.browseBtn.UseVisualStyleBackColor = true;
            this.browseBtn.Click += new System.EventHandler(this.browseBtn_Click);
            // 
            // createEmpBtn
            // 
            this.createEmpBtn.Location = new System.Drawing.Point(911, 25);
            this.createEmpBtn.Name = "createEmpBtn";
            this.createEmpBtn.Size = new System.Drawing.Size(276, 59);
            this.createEmpBtn.TabIndex = 14;
            this.createEmpBtn.Text = "Create Employee";
            this.createEmpBtn.UseVisualStyleBackColor = true;
            this.createEmpBtn.Click += new System.EventHandler(this.createEmpBtn_Click);
            // 
            // EmployeeDataTable
            // 
            this.EmployeeDataTable.AllowUserToAddRows = false;
            this.EmployeeDataTable.AllowUserToDeleteRows = false;
            this.EmployeeDataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeeDataTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.txtName,
            this.Email,
            this.txtGender});
            this.EmployeeDataTable.Location = new System.Drawing.Point(61, 79);
            this.EmployeeDataTable.Name = "EmployeeDataTable";
            this.EmployeeDataTable.ReadOnly = true;
            this.EmployeeDataTable.RowHeadersWidth = 51;
            this.EmployeeDataTable.RowTemplate.Height = 24;
            this.EmployeeDataTable.Size = new System.Drawing.Size(750, 205);
            this.EmployeeDataTable.TabIndex = 15;
            this.EmployeeDataTable.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmployeeDataTable_CellDoubleClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 125;
            // 
            // txtName
            // 
            this.txtName.DataPropertyName = "txtName";
            this.txtName.HeaderText = "Employee Name";
            this.txtName.MinimumWidth = 6;
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Width = 125;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Employee Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 125;
            // 
            // txtGender
            // 
            this.txtGender.DataPropertyName = "Gender";
            this.txtGender.HeaderText = "Gender";
            this.txtGender.MinimumWidth = 6;
            this.txtGender.Name = "txtGender";
            this.txtGender.ReadOnly = true;
            this.txtGender.Width = 125;
            // 
            // searchEmployeeTxt
            // 
            this.searchEmployeeTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchEmployeeTxt.Location = new System.Drawing.Point(190, 25);
            this.searchEmployeeTxt.Multiline = true;
            this.searchEmployeeTxt.Name = "searchEmployeeTxt";
            this.searchEmployeeTxt.Size = new System.Drawing.Size(360, 36);
            this.searchEmployeeTxt.TabIndex = 16;
            this.searchEmployeeTxt.TextChanged += new System.EventHandler(this.searchEmployeeTxt_TextChanged);
            // 
            // goToChangePasswordForm
            // 
            this.goToChangePasswordForm.Location = new System.Drawing.Point(911, 105);
            this.goToChangePasswordForm.Name = "goToChangePasswordForm";
            this.goToChangePasswordForm.Size = new System.Drawing.Size(276, 42);
            this.goToChangePasswordForm.TabIndex = 17;
            this.goToChangePasswordForm.Text = "Change My Pasword";
            this.goToChangePasswordForm.UseVisualStyleBackColor = true;
            this.goToChangePasswordForm.Click += new System.EventHandler(this.goToChangePasswordForm_Click);
            // 
            // logOutBtn
            // 
            this.logOutBtn.Location = new System.Drawing.Point(911, 172);
            this.logOutBtn.Name = "logOutBtn";
            this.logOutBtn.Size = new System.Drawing.Size(276, 42);
            this.logOutBtn.TabIndex = 18;
            this.logOutBtn.Text = "Log Out";
            this.logOutBtn.UseVisualStyleBackColor = true;
            this.logOutBtn.Click += new System.EventHandler(this.logOutBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NoticeId,
            this.Details});
            this.dataGridView1.Location = new System.Drawing.Point(812, 320);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(375, 150);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // NoticeId
            // 
            this.NoticeId.DataPropertyName = "NoticeId";
            this.NoticeId.HeaderText = "Id";
            this.NoticeId.MinimumWidth = 6;
            this.NoticeId.Name = "NoticeId";
            this.NoticeId.ReadOnly = true;
            this.NoticeId.Width = 125;
            // 
            // Details
            // 
            this.Details.DataPropertyName = "Details";
            this.Details.HeaderText = "Details";
            this.Details.MinimumWidth = 6;
            this.Details.Name = "Details";
            this.Details.ReadOnly = true;
            this.Details.Width = 125;
            // 
            // sendNoticeBtn
            // 
            this.sendNoticeBtn.Location = new System.Drawing.Point(911, 565);
            this.sendNoticeBtn.Name = "sendNoticeBtn";
            this.sendNoticeBtn.Size = new System.Drawing.Size(161, 37);
            this.sendNoticeBtn.TabIndex = 20;
            this.sendNoticeBtn.Text = "Send Notice";
            this.sendNoticeBtn.UseVisualStyleBackColor = true;
            this.sendNoticeBtn.Click += new System.EventHandler(this.sendNoticeBtn_Click);
            // 
            // noticeTxt
            // 
            this.noticeTxt.Location = new System.Drawing.Point(835, 486);
            this.noticeTxt.Multiline = true;
            this.noticeTxt.Name = "noticeTxt";
            this.noticeTxt.Size = new System.Drawing.Size(298, 73);
            this.noticeTxt.TabIndex = 21;
            // 
            // UserHomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 704);
            this.Controls.Add(this.noticeTxt);
            this.Controls.Add(this.sendNoticeBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.logOutBtn);
            this.Controls.Add(this.goToChangePasswordForm);
            this.Controls.Add(this.searchEmployeeTxt);
            this.Controls.Add(this.EmployeeDataTable);
            this.Controls.Add(this.createEmpBtn);
            this.Controls.Add(this.browseBtn);
            this.Controls.Add(this.editEmployeeBtn);
            this.Controls.Add(this.deleteEmployeeBtn);
            this.Controls.Add(this.employeeUpdateBtn);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.emailTxt);
            this.Controls.Add(this.salaryTxt);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UserHomeForm";
            this.Text = "UserHomeForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeDataTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.TextBox salaryTxt;
        private System.Windows.Forms.TextBox emailTxt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton femaleRadioBtn;
        private System.Windows.Forms.RadioButton maleRadioBtn;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button employeeUpdateBtn;
        private System.Windows.Forms.Button deleteEmployeeBtn;
        private System.Windows.Forms.Button editEmployeeBtn;
        private System.Windows.Forms.Button browseBtn;
        private System.Windows.Forms.Button createEmpBtn;
        private System.Windows.Forms.DataGridView EmployeeDataTable;
        private System.Windows.Forms.TextBox searchEmployeeTxt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtGender;
        private System.Windows.Forms.Button goToChangePasswordForm;
        private System.Windows.Forms.Button logOutBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoticeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Details;
        private System.Windows.Forms.Button sendNoticeBtn;
        private System.Windows.Forms.TextBox noticeTxt;
    }
}