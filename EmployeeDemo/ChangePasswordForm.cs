using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeDemo
{
    public partial class ChangePasswordForm : Form
    {
        public ChangePasswordForm()
        {
            InitializeComponent();
        }

        private void updatePasswordBtn_Click(object sender, EventArgs e)
        {
            bool validation = this.CheckInputValidation();
            if (validation == true)
            {
                SqlDataReader data = new Database().GetPresentPassword(UserHomeForm.employeeId);

                if (data.HasRows)
                {
                    while (data.Read())
                    {
                        //If the user current password does not match with what the user has given, then following line executes.
                        if (this.currentPasswordTxt.Text != data[0].ToString())
                        {
                            MessageBox.Show("Wrong Current password! Enter the correct one");
                            return;
                        }

                        //If the user has give the right current password, then it is proceeded
                        int row = new Database().UpdatePassword(UserHomeForm.employeeId, this.newPasswordTxt.Text);
                        if (row > 0)
                        {
                            MessageBox.Show("Password Updated Successfully");
                            new UserHomeForm().Show();
                            this.Hide();
                        }
                    }
                }
            }
        }

        public bool CheckInputValidation()
        {
            if(this.currentPasswordTxt.Text == "" || this.newPasswordTxt.Text == "")
            {
                MessageBox.Show("Input Fields cannot be empty");
                return false;
            }
            if(this.currentPasswordTxt.Text.Length > 20)
            {
                MessageBox.Show("Current Password Cannot be greater than 20");
                return false;
            }
            if (this.newPasswordTxt.Text.Length > 20)
            {
                MessageBox.Show("New Password Cannot be greater than 20");
                return false;
            }

            return true;
        }

        private void goToUserHomeFormBtn_Click(object sender, EventArgs e)
        {
            new UserHomeForm().Show();
            this.Hide();
        }
    }
}
